using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Model
{
    [Table("RILETA.AUTO_ERRORS")]
    public partial class AUTO_ERRORS
    {
        [Key]
        public int AeR_Id { get; set; }
        [Required]
        public string AeR_Message { get; set; }
        public int AeR_Type { get; set; }
        [Required]
        public string AeR_Method { get; set; }
        [Required]
        public string AeR_Process { get; set; }
        [Required]
        public DateTime AeR_DateAdded { get; set; }
    }


}
