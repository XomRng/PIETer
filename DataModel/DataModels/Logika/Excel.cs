using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing;
using OfficeOpenXml.Style;


namespace DataModels.Logika
{
    public static class Excel
    {
        public static void AddListToExcelFile<T>(string sheetName, List<T> list, ExcelPackage excel)
        {
            int row = 2;
            int col = 1;
            var ws = excel.Workbook.Worksheets.Add(sheetName);


            list.ForEach(o => // rows
            {
                Type myType = o.GetType();
                IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());

                foreach (PropertyInfo prop in props)
                {
                    if (row == 2)
                    {
                        ws.Cells[1, col].Value = prop.Name;
                        BoldIt(ws.Cells[1, col]);
                        BorderIt(ws.Cells[1, col]);
                    }
                    ws.Cells[row, col].Value = prop.GetValue(o, null);
                    BorderIt(ws.Cells[row, col]);
                    col++;
                }
                col = 1;
                row++;
            });
            ws.Cells.AutoFitColumns();
        }

        public static void SaveToFile<T>(string sheetName, List<T> lista, string filePath)
        {
            //string filePath = ConfigurationManager.AppSettings[ConfigKey.attachmentFilePath] + fileName;
            Tools.DeleteFileIfExists(filePath);
            FileInfo newFile = new FileInfo(filePath);

            using (ExcelPackage excel = new ExcelPackage(newFile))
            {
                int row = 2;
                int col = 1;
                var ws = excel.Workbook.Worksheets.Add(sheetName);


                lista.ForEach(o => // rows
                {
                    Type myType = o.GetType();
                    IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());

                    foreach (PropertyInfo prop in props)
                    {
                        if (row == 2)
                        {
                            ws.Cells[1, col].Value = prop.Name;
                            BoldIt(ws.Cells[1, col]);
                            BorderIt(ws.Cells[1, col]);
                        }
                        ws.Cells[row, col].Value = prop.GetValue(o, null);
                        BorderIt(ws.Cells[row, col]);
                        col++;
                    }
                    col = 1;
                    row++;
                });
                ws.Cells.AutoFitColumns();

                excel.Save();
            }
        }

        public static void SaveToFile<T>(List<T> lista, string filePath)
        {
            //string filePath = ConfigurationManager.AppSettings[ConfigKey.attachmentFilePath] + fileName;
            Tools.DeleteFileIfExists(filePath);
            FileInfo newFile = new FileInfo(filePath);

            using (ExcelPackage excel = new ExcelPackage(newFile))
            {
                int row = 2;
                int col = 1;
                var ws = excel.Workbook.Worksheets.Add("Log");
                

                lista.ForEach(o => // rows
                {
                    Type myType = o.GetType();
                    IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());

                    foreach (PropertyInfo prop in props)
                    {
                        if (row == 2)
                        {
                            ws.Cells[1, col].Value = prop.Name;
                            BoldIt(ws.Cells[1, col]);
                            BorderIt(ws.Cells[1, col]);
                        }
                        ws.Cells[row, col].Value = prop.GetValue(o, null);
                        BorderIt(ws.Cells[row, col]);
                        col++;
                    }
                    col = 1;
                    row++;
                });
                ws.Cells.AutoFitColumns();
               
                excel.Save();
            }
        }

        private static void BoldIt(ExcelRange param)
        {
            param.Style.Font.Bold = true;
        }

        private static void BorderIt(ExcelRange param)
        {
            param.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            param.Style.Border.Top.Style = ExcelBorderStyle.Thin;
            param.Style.Border.Left.Style = ExcelBorderStyle.Thin;
            param.Style.Border.Right.Style = ExcelBorderStyle.Thin;
        }

        public static void SaveToFile<T>(List<T> lista, string fileName, string sheetName)
        {
            string filePath = ConfigurationManager.AppSettings[ConfigKey.attachmentFilePath] + fileName;
            Tools.DeleteFileIfExists(filePath);
            FileInfo newFile = new FileInfo(filePath);

            using (ExcelPackage excel = new ExcelPackage(newFile))
            {
                int row = 2;
                int col = 1;
                var ws = excel.Workbook.Worksheets.Add(sheetName);

                lista.ForEach(o => // rows
                {
                    Type myType = o.GetType();
                    IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties()); 

                    foreach (PropertyInfo prop in props)
                    {
                        if (row == 2)
                            ws.Cells[1, col].Value = prop.Name;
                        ws.Cells[row, col].Value = prop.GetValue(o, null);
                        col++;
                    }
                    col = 1;
                    row++;
                });
                ws.Cells.AutoFitColumns();
                excel.Save();
            }
        }

       

        public static void SaveToFile<T>(List<List<T>> lista, string fileName, string[] sheetNames)
        {
            if (lista.Count > 0)
            {
                string filePath = ConfigurationManager.AppSettings[ConfigKey.attachmentFilePath] + fileName;
                Tools.DeleteFileIfExists(filePath);
                int counter = 0;
                FileInfo newFile = new FileInfo(filePath);

                using (ExcelPackage excel = new ExcelPackage(newFile))
                {
                    
                    int row = 2;
                    int col = 1;

                    lista.ForEach(l => // arkusze
                    {
                        
                        var ws = excel.Workbook.Worksheets.Add(sheetNames[counter]);
                        l.ForEach(o =>   // rzędy
                        {
                            Type myType = o.GetType();
                            IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());
 
                        
                            foreach (PropertyInfo prop in props) // kolumny
                            {
                                if(row == 2)
                                    ws.Cells[1, col].Value = prop.Name;
                                ws.Cells[row,col].Value = prop.GetValue(o, null);
                                //iterujemy przez kazde property
                                // trzeba jeszcze tylko zrobyc zeby nadawal na poczatku tytuly kolumnom
                                col++;
                            }
                            col = 1;
                            row++;
                        });
                        row = 2;
                        counter++;
                        ws.Cells.AutoFitColumns();
                    });
                    
                    excel.Save();
                }
            }
        }
    }
}
