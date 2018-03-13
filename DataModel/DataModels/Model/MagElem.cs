namespace DataModels.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CDN.MagElem")]
    public partial class MagElem
    {
        public short? MaE_GIDTyp { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaE_GIDNumer { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short MaE_GIDLp { get; set; }

        public short? MaE_Pozycja { get; set; }

        public short? MaE_TwrTyp { get; set; }

        public int? MaE_TwrNumer { get; set; }

        [StringLength(40)]
        public string MaE_TwrKod { get; set; }

        public short? MaE_CCKTyp { get; set; }

        public int? MaE_CCKNumer { get; set; }

        [StringLength(20)]
        public string MaE_Cecha { get; set; }

        public short? MaE_CCK2Typ { get; set; }

        public int? MaE_CCK2Numer { get; set; }

        [StringLength(20)]
        public string MaE_Cecha2 { get; set; }

        [StringLength(40)]
        public string MaE_Ean { get; set; }

        public int? MaE_DataW { get; set; }

        public decimal? MaE_Ilosc { get; set; }

        public byte? MaE_JmFormat { get; set; }

        [StringLength(8)]
        public string MaE_JmZ { get; set; }

        public byte? MaE_JmFormatZ { get; set; }

        public byte? MaE_TypJm { get; set; }

        public decimal? MaE_PrzeliczM { get; set; }

        public decimal? MaE_PrzeliczL { get; set; }

        public int? MaE_JednostkaLog { get; set; }

        public int? MaE_TPaId { get; set; }

        public short? MaE_OpeTyp { get; set; }

        public int? MaE_OpeFirma { get; set; }

        public int? MaE_OpeNumer { get; set; }

        public short? MaE_OpeLp { get; set; }

        [StringLength(1023)]
        public string MaE_Opis { get; set; }

        public byte? MaE_Status { get; set; }

        public decimal? MaE_IloscMin { get; set; }

        public decimal? MaE_IloscMax { get; set; }

        public virtual MagNag MagNag { get; set; }
    }
}
