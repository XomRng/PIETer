using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Model
{
    [Table("ifs.PartieZamowien")]
    public class PartieZamowien
    {
        [Key]
        public int Id { get; set; }
        public int ZSID { get; set; }
        public int ZSLp { get; set; }
        public decimal Ilosc { get; set; }
        public string PartiaXML { get; set; }
        public string PartiaSkan { get; set; }
    }
}
