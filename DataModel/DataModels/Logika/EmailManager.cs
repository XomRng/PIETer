using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Logika
{
    public static class EmailManager
    {
        private static string nadawca;
        private static string login;
        private static string pass;
        private static string smtp;

        static EmailManager()
        {
            nadawca = ConfigurationManager.AppSettings[ConfigKey.emailNadawca];
            login = ConfigurationManager.AppSettings[ConfigKey.emailLogin];
            pass = ConfigurationManager.AppSettings[ConfigKey.emailPass];
            smtp = ConfigurationManager.AppSettings[ConfigKey.emailSMTP];
        }

        public static bool SendMail(Email email)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    
                    SmtpClient SmtpC = new SmtpClient(smtp);
                    mail.From = new MailAddress(nadawca);

                    SmtpC.Port = 587;
                    SmtpC.Credentials = new System.Net.NetworkCredential(login, pass);
                    SmtpC.EnableSsl = true;

                    mail.Subject = email.Temat;
                    
                    mail.IsBodyHtml = email.HtmlBody;
                    if (mail.IsBodyHtml == true)
                    {
                        mail.Body = email.CSSHeader;
                        mail.BodyEncoding = Encoding.UTF8;
                    }
                    mail.Body += email.Tresc;


                    if (email.Odbiorcy != null)
                        foreach (string s in email.Odbiorcy)
                        {
                            if(!String.IsNullOrWhiteSpace(s))
                                mail.To.Add(s);
                        }

                    if (email.OdbiorcyBCC != null)
                        foreach (string s in email.OdbiorcyBCC)
                        {
                            mail.Bcc.Add(s);
                        }
                    if (email.OdbiorcyDoWiadomosci != null)
                        foreach (string s in email.OdbiorcyDoWiadomosci)
                        {
                            mail.CC.Add(s);
                        }

                    if (email.Attachments != null)
                        foreach (string attachment in email.Attachments)
                        {
                            mail.Attachments.Add(new Attachment(attachment));
                        }

                    if(email.Odbiorcy.Where(s=>!String.IsNullOrWhiteSpace(s)).ToList().Count > 0)
                        SmtpC.Send(mail);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
           
        }

        public static bool SendMail(string temat, string tresc, string[] odbiorcy, string[] attachments)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    SmtpClient SmtpC = new SmtpClient(smtp);
                    mail.From = new MailAddress(nadawca);

                    foreach (string s in odbiorcy)
                    {
                        mail.To.Add(s);
                    }

                    mail.Subject = temat;
                    mail.Body = tresc;


                    foreach (string attachment in attachments)
                    {
                        mail.Attachments.Add(new Attachment(attachment));
                    }

                    SmtpC.Port = 587;
                    SmtpC.Credentials = new System.Net.NetworkCredential(login, pass);
                    SmtpC.EnableSsl = true;


                    SmtpC.Send(mail);

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }   
        }

        public static void SendErrorMessage(string procesName)
        {
            try
            {
                if (ErrorManager.CaughtErrors.Count > 0)
                {
                    Email mail = new Email
                    {
                        Attachments = null,
                        HtmlBody = false,
                        Odbiorcy = new string[] { ConfigurationManager.AppSettings[ConfigKey.odbiorcyErrors] },
                        OdbiorcyBCC = null,
                        Temat = "ERROR - " + procesName
                    };

                    ErrorManager.CaughtErrors.ForEach(e =>
                    {
                        mail.Tresc += e.Process + Environment.NewLine + e.Method + Environment.NewLine + e.ErrorMessage
                                      + Environment.NewLine + Environment.NewLine;

                    });
                    EmailManager.SendMail(mail);
                }
            }
            catch (System.Net.Mail.SmtpException)
            {
               
            }
            
        }

        public static void SendErrorMessage(string procesName, Exception ex)
        {
            try
            {
                if (ErrorManager.CaughtErrors.Count > 0)
                {
                    Email mail = new Email
                    {
                        Attachments = null,
                        HtmlBody = false,
                        Odbiorcy = Tools.ParseOdbiorcy( ConfigurationManager.AppSettings[ConfigKey.odbiorcyErrors]),
                        OdbiorcyBCC = null,
                        Temat = "ERROR - " + procesName
                    };

                    ErrorManager.CaughtErrors.ForEach(e =>
                    {
                        mail.Tresc += e.Process + Environment.NewLine + e.Method + Environment.NewLine + e.ErrorMessage
                                      + Environment.NewLine  + e.Target + Environment.NewLine + Environment.NewLine;

                    });

                    if (ex != null)
                        mail.Tresc += Environment.NewLine + ex.Message;

                    EmailManager.SendMail(mail);
                }
            }
            catch (System.Net.Mail.SmtpException)
            {

            }

        }
    }

    public class Email
    {
        public string Temat { get; set; }
        public string Tresc { get; set; }
        public string[] Attachments { get; set; }
        public string[] Odbiorcy { get; set; }
        public string[] OdbiorcyBCC { get; set; }
        public string[] OdbiorcyDoWiadomosci { get; set; }
        public bool HtmlBody { get; set; }

        private string TableCSS =
                "<head><style>table, th, td {border: 1px solid black; border-collapse: collapse;padding: 5px;  } table {width: 70%;} tr {text-align: center}</style></head>";
            
        public string CSSHeader { get { return TableCSS; } }

        public Email()
        {
           // Tresc = TableCSS;
        }
    }
}
