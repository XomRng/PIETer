using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Model
{
    [Table("CDN.ZaNOpisy")]
    public partial class ZaNOpisy
    {
        [Key]
        public int ZnO_ZamTyp { get; set; }
        public int ZnO_ZamFirma { get; set; }
        public int ZnO_ZamNumer { get; set; }
        public int ZnO_ZamLp { get; set; }
        public int ZnO_Typ { get; set; }
        [StringLength(1999)]
        public string ZnO_Opis { get; set; }
    }
}
