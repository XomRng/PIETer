namespace DataModels.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CDN.MagSElem")]
    public partial class MagSElem
    {
        public short? MaS_GIDTyp { get; set; }

        public int? MaS_GIDFirma { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaS_GIDNumer { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short MaS_GIDLp { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short MaS_SubGIDLp { get; set; }

        public short? MaS_DstTyp { get; set; }

        public int? MaS_DstFirma { get; set; }

        public int? MaS_DstNumer { get; set; }

        public short? MaS_DstLp { get; set; }

        public short? MaS_MagTyp { get; set; }

        public int? MaS_MagFirma { get; set; }

        public int? MaS_MagNumer { get; set; }

        public short? MaS_MagLp { get; set; }

        public short? MaS_ZrdTyp { get; set; }

        public int? MaS_ZrdFirma { get; set; }

        public int? MaS_ZrdNumer { get; set; }

        public short? MaS_ZrdLp { get; set; }

        public short? MaS_SubZrdLp { get; set; }

        public short? MaS_TwrTyp { get; set; }

        public int? MaS_TwrFirma { get; set; }

        public int? MaS_TwrNumer { get; set; }

        public short? MaS_TwrLp { get; set; }

        public decimal? MaS_Ilosc { get; set; }

        public int? MaS_TrnTStamp { get; set; }

        public short? MaS_ZlcTyp { get; set; }

        public int? MaS_ZlcFirma { get; set; }

        public int? MaS_ZlcNumer { get; set; }

        public short? MaS_ZlcLp { get; set; }
    }
}
