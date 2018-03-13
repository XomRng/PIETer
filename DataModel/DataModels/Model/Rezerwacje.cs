using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Model
{
    [Table("CDN.Rezerwacje")]
    public class Rezerwacje
    {
        public int? Rez_GIDTyp { get; set; }
        public int? Rez_GIDFirma { get; set; }
        [Key]
        public int Rez_GIDNumer { get; set; }

        public int? Rez_ZrdTyp { get; set; }
        public int? Rez_ZrdFirma { get; set; }
        public int? Rez_ZrdNumer { get; set; }
        public int? Rez_ZrdLp { get; set; }

        public decimal? Rez_Ilosc { get; set; }
        public decimal? Rez_Zrealizowano { get; set; }
        public decimal? Rez_IloscMag { get; set; }
        public decimal? Rez_IloscImp { get; set; }
        public decimal? Rez_IloscSSC { get; set; }
        public decimal? Rez_IloscSAD { get; set; }


    }
}
