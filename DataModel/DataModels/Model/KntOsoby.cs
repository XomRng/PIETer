using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Model
{
    [Table("cdn.KntOsoby")]
    public partial class KntOsoby
    {
        public int KnS_KntTyp { get; set; }
        public int KnS_KntFirma { get; set; }
        public int KnS_KntLp { get; set; }
        [Key]
        public int KnS_KntNumer { get; set; }

        public string KnS_Dzial { get; set; }
        public string KnS_Stanowisko { get; set; }
        public string KnS_Tytul { get; set; }
        public string KnS_Nazwa { get; set; }
        public string KnS_Telefon { get; set; }
        public string KnS_EMail { get; set; }




    }
}
