using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using DataModels.Logika;

namespace DataModels.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;



    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {
            Database.CommandTimeout = 180;
        }

        public  DbSet<Atrybuty> Atrybuty { get; set; }
        public  DbSet<AtrybutyKlasy> AtrybutyKlasy { get; set; }
        public  DbSet<KntAdresy> KntAdresy { get; set; }
        public  DbSet<KntKarty> KntKarty { get; set; }
        public  DbSet<Magazyny> Magazyny { get; set; }
        public  DbSet<MagElem> MagElem { get; set; }
        public  DbSet<MagNag> MagNag { get; set; }
        public  DbSet<MagSElem> MagSElem { get; set; }
        public  DbSet<TraElem> TraElem { get; set; }
        public  DbSet<TraNag> TraNag { get; set; }
        public  DbSet<TwrKarty> TwrKarty { get; set; }
        public  DbSet<ZamElem> ZamElem { get; set; }
        public  DbSet<ZamNag> ZamNag { get; set; }
        public  DbSet<ZaNOpisy> ZaNOpisy { get; set; }
        public  DbSet<AUTO_ZS_Flagi> AUTO_ZS_Flagi { get; set; }
        public  DbSet<AUTO_WM_Flagi> AUTO_WM_Flagi { get; set; }
        public  DbSet<AUTO_PW_Flagi> AUTO_PW_Flagi { get; set; }
        public  DbSet<AUTO_ERRORS> AUTO_ERRORS { get; set; }
        public  DbSet<KntOsoby> KntOsoby { get; set; }
        public  DbSet<TraSElem> TraSElems { get; set; }
        public  DbSet<Rezerwacje> Rezerwacje { get; set; }
        public  DbSet<PartieZamowien> PartieZamowien { get; set; }

        public bool IsConnected()
        {
            try
            {
                this.Database.Connection.Open();
                this.Database.Connection.Close();
            }
            catch (SqlException e)
            {
                return false;
            }
            return true;
        }

        public List<ReturnModelType> GetResultFromSqlFile<ReturnModelType>(string sqlFilePath)
        {
            var sqlQuery = GetQueryFromFile(sqlFilePath);

            var result = this.Database.SqlQuery(typeof(ReturnModelType), sqlQuery);

            List<ReturnModelType> localModels = new List<ReturnModelType>();
            foreach (var o in result)
            {

                ReturnModelType m = (ReturnModelType)o;
                localModels.Add(m);
            }
            return localModels;
        }

        public List<ReturnModelType> GetResultFromSqlQuery<ReturnModelType>(string sqlQuery)
        {
            var result = this.Database.SqlQuery(typeof(ReturnModelType), sqlQuery);
            List<ReturnModelType> localModels = new List<ReturnModelType>();
            foreach (var o in result)
            {

                ReturnModelType m = (ReturnModelType)o;
                localModels.Add(m);
            }
            return localModels;
        }

        private string GetQueryFromFile(string sqlFilePath)
        {
            TextReader tr = new StreamReader(sqlFilePath);
            string result = "";
            string tmp;
            while ((tmp = tr.ReadLine()) != null)
            {
                result += " " + tmp;
            }
            return result;
        }
      
        public string GetAtr(int typ, int gid, int id)
        {
            var result = this.Database
                .SqlQuery<string>("select ifs.PodajAtrybut(@GidTyp, @GidNumer, "+id.ToString()+")"
                    , new SqlParameter("@GidTyp", typ)
                    , new SqlParameter("@GidNumer", gid))
                .FirstOrDefault();
            return result;
        }

        public string GetAtrLp(int typ, int gid, int lp, int id)
        {
            var result = this.Database
                .SqlQuery<string>("select ifs.PodajAtrybutLp(@GidTyp, @GidNumer, @AtkId, @GidLp)"
                    , new SqlParameter("@GidTyp", typ)
                    , new SqlParameter("@GidNumer", gid)
                    , new SqlParameter("@GidLp", lp)
                    , new SqlParameter("@AtkId", id))
                .FirstOrDefault();
            return result;
        }

        public void SetAtr(int typ, int gid, int id, string wartosc)
        {
            Database.ExecuteSqlCommand("exec ifs.AktualizujAtrybut @GidTyp, @GidNumer, @AtkId, @Wartosc"
                , new SqlParameter("@GidTyp", typ)
                , new SqlParameter("@GidNumer", gid)
                , new SqlParameter("@AtkId", id)
                , new SqlParameter("@Wartosc", wartosc));
        }

        public void SetAtrLp(int typ, int gid, int id, string wartosc, int lp)
        {
            Database.ExecuteSqlCommand("exec ifs.AktualizujAtrybutLp @GidTyp, @GidNumer, @AtkId, @Wartosc, @GidLp"
                , new SqlParameter("@GidTyp", typ)
                , new SqlParameter("@GidNumer", gid)
                , new SqlParameter("@AtkId", id)
                , new SqlParameter("@Wartosc", wartosc)
                , new SqlParameter("@GidLp", lp));
        }



        public string GetDokument(int? typ, int? gid)
        {
            if (typ == null || gid == null)
                return "";

            var result = this.Database
                .SqlQuery<string>("select ifs.Dokument(@GidTyp, @GidNumer)"
                    , new SqlParameter("@GidTyp", typ)
                    , new SqlParameter("@GidNumer", gid))
                .FirstOrDefault();

            if (result!=null)
                return result;

            return "";
        }

        public string GetNruKont(int? zantyp, int? zannumer)
        {
            if (zantyp == null || zannumer == null)
                return "";

            var result = this.Database
                .SqlQuery<string>("select ZaN_DokumentObcy from cdn.zamnag where ZaN_GidNumer = @gid AND ZaN_GidTyp = @typ"
                    , new SqlParameter("@gid", zannumer)
                    , new SqlParameter("@typ", zantyp)
                ).FirstOrDefault();

            if (result != null)
                return result;

            return "";

        }

        public string GetNruKont(string nrzs)
        {
            if (nrzs == null)
                return "";

            var nrzsc = nrzs.ToCharArray().Skip(3).ToArray();
            string nr = "";
            string mies = "";
            string rok = "";
            string seria = "";
            int index = 0;

            foreach (char c in nrzsc)
            {
                if(c.Equals('/'))
                    break;
                index++;
                nr += c;
            }
            nrzsc = nrzsc.Skip(index+1).ToArray();
            index = 0;

            foreach (char c in nrzsc)
            {
                if (c.Equals('/'))
                    break;
                index++;
                mies += c;
            }
            nrzsc = nrzsc.Skip(index + 1).ToArray();
            index = 0;

            foreach (char c in nrzsc)
            {
                if (c.Equals('/'))
                    break;
                index++;
                rok += c;
            }
            rok = "20" + rok;
            nrzsc = nrzsc.Skip(index + 1).ToArray();
            index = 0;

            foreach (char c in nrzsc)
            {
                if (c.Equals('/'))
                    break;
                index++;
                seria += c;
            }
            var r = rok.ToInt32();
            var m = mies.ToInt32();
            var n = nr.ToInt32();
          
            var result = this.ZamNag.Where(z => z.ZaN_ZamSeria.Equals(seria)
                                             && z.ZaN_ZamRok == r
                                             && z.ZaN_ZamMiesiac == m
                                             && z.ZaN_ZamNumer == n
                                             && z.ZaN_ZamTyp == 1280
                                             && z.ZaN_GIDTyp == 960)
                                    .Select(z=>z.ZaN_DokumentObcy)
                                    .FirstOrDefault();
            if (result == null)
                return "";
                
            return result;

        }


    }
}
