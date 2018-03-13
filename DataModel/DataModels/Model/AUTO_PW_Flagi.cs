using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Model
{
    [Table("RILETA.AUTO_PW_Flagi")]
    public partial class AUTO_PW_Flagi
    {
        [Key]
        public int ApF_Id { get; set; }
        [Required]
        public int ApF_TrNTyp { get; set; }
        [Required]
        public int ApF_TrNNumer { get; set; }
        [Required]
        public int ApF_TrNFirma { get; set; }

        public bool ApF_PWDoWygenerowania { get; set; }

        public bool ApF_PWInfo { get; set; }
    }
}
