using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Model
{
    [Table("CDN.TraSElem")]
    public partial class TraSElem
    {
        public int TrS_GIDTyp { get; set; }
        public int TrS_GIDFirma { get; set; }
        [Key]
        public int TrS_GIDNumer { get; set; }
        public int TrS_GIDLp { get; set; }
        public string TrS_Cecha { get; set; }

    }
}
