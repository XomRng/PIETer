using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Model
{
    [Table("RILETA.AUTO_ZS_Flagi")]
    public partial class AUTO_ZS_Flagi
    {
        [Key]
        public int AzF_Id { get; set; }
        [Required]
        public int AzF_ZaNTyp { get; set; }
        [Required]
        public int AzF_ZaNNumer { get; set; }
        [Required]
        public int AzF_ZaNFirma { get; set; }
        public bool AzF_NewOttoZlc { get; set; }
        public bool AzF_OrderConfirmation { get; set; }
        public bool AzF_FIX { get; set; }
    }
}
