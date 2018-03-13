namespace DataModels.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CDN.Atrybuty")]
    public partial class Atrybuty
    {
        [Key]
        public int Atr_Id { get; set; }

        public short? Atr_ObiTyp { get; set; }

        public int? Atr_ObiFirma { get; set; }

        public int? Atr_ObiNumer { get; set; }

        public short? Atr_ObiLp { get; set; }

        public short? Atr_ObiSubLp { get; set; }

        public int? Atr_AtkId { get; set; }

        [StringLength(255)]
        public string Atr_Wartosc { get; set; }

        public short? Atr_AtrTyp { get; set; }

        public int? Atr_AtrFirma { get; set; }

        public int? Atr_AtrNumer { get; set; }

        public short? Atr_AtrLp { get; set; }

        public short? Atr_AtrSubLp { get; set; }

        public int? Atr_OptimaId { get; set; }

        public virtual AtrybutyKlasy AtrybutyKlasy { get; set; }
    }
}
