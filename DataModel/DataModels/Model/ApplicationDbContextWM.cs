using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Model
{
    public partial class ApplicationDbContext : DbContext
    {
        public string GetPostDate(int? wmtyp, int? wmgid)
        {
            var gls = this.Database
                .SqlQuery<string>("select ifs.PodajAtrybut(@typ, @gid, 28)"
                    , new SqlParameter("@gid", wmgid)
                    , new SqlParameter("@typ", wmtyp)
                ).FirstOrDefault();

            var rze = this.Database
                .SqlQuery<string>("select ifs.PodajAtrybut(@typ, @gid, 49)"
                    , new SqlParameter("@gid", wmgid)
                    , new SqlParameter("@typ", wmtyp)
                ).FirstOrDefault();

            if(String.IsNullOrWhiteSpace(gls) && String.IsNullOrWhiteSpace(rze))
                 return "";

            if (!String.IsNullOrWhiteSpace(gls) && String.IsNullOrWhiteSpace(rze))
                return "GLS: " + gls;

            if (String.IsNullOrWhiteSpace(gls) && !String.IsNullOrWhiteSpace(rze))
                return "Rzeczywista: " + rze;

            return "GLS: " + gls + "<br>" + "Rzeczywista: " + rze;

        }

        public bool GetFix(int? wmtyp, int? wmgid)
        {
            var result = (from MNag in this.MagNag
                from MSElem in this.MagSElem
                where MNag.MaN_GIDNumer == MSElem.MaS_GIDNumer
                from ZNag in this.ZamNag
                where ZNag.ZaN_GIDTyp == MSElem.MaS_ZlcTyp && ZNag.ZaN_GIDNumer == MSElem.MaS_ZlcNumer
                from ZElem in this.ZamElem
                where ZNag.ZaN_GIDNumer == ZElem.ZaE_GIDNumer
                          where MNag.MaN_GIDTyp == wmtyp && MNag.MaN_GIDNumer == wmgid
                select new
                {
                    Typ = ZElem.ZaE_GIDTyp,
                    Gid = ZElem.ZaE_GIDNumer,
                    Lp = ZElem.ZaE_GIDLp
                    

                }).ToList();

            List<string> lfix = new List<string>();
            result.ForEach(r =>
            {
                lfix.Add(this.GetAtrLp((int)r.Typ, r.Gid, r.Lp, 69));
            });

            lfix = lfix.Where(l => !String.IsNullOrWhiteSpace(l)).ToList();

            if (lfix.Count > 0)
            {
                return true;
            }

            return false;
        }
    }
}
