using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Model
{
    [Table("RILETA.AUTO_WM_Flagi")]
    public partial class AUTO_WM_Flagi
    {
        [Key]
        public int AwF_Id { get; set; }
        [Required]
        public int AwF_MaNTyp { get; set; }
        [Required]
        public int AwF_MaNNumer { get; set; }
        [Required]
        public int AwF_MaNFirma { get; set; }
        public bool AwF_OTTOSent { get; set; }
        public bool AwF_CHNOSent { get; set; }
        public bool AwF_FIXSent { get; set; }
        public bool AwF_EXPSent { get; set; }
    }
}
