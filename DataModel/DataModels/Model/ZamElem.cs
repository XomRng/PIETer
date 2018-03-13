namespace DataModels.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CDN.ZamElem")]
    public partial class ZamElem
    {
        public short? ZaE_GIDTyp { get; set; }

        public int? ZaE_GIDFirma { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ZaE_GIDNumer { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ZaE_GIDLp { get; set; }

        public short? ZaE_TwrTyp { get; set; }

        public int? ZaE_TwrFirma { get; set; }

        public int? ZaE_TwrNumer { get; set; }

        public short? ZaE_TwrLp { get; set; }

        [StringLength(255)]
        public string ZaE_TwrNazwa { get; set; }

        [StringLength(40)]
        public string ZaE_TwrKod { get; set; }

        public short? ZaE_KntTyp { get; set; }

        public int? ZaE_KntFirma { get; set; }

        public int? ZaE_KntNumer { get; set; }

        public short? ZaE_KntLp { get; set; }

        public short? ZaE_AkwTyp { get; set; }

        public int? ZaE_AkwFirma { get; set; }

        public int? ZaE_AkwNumer { get; set; }

        public short? ZaE_AkwLp { get; set; }

        public short? ZaE_CChTyp { get; set; }

        public int? ZaE_CChFirma { get; set; }

        public int? ZaE_CChNumer { get; set; }

        public short? ZaE_CChLp { get; set; }

        public short? ZaE_MagTyp { get; set; }

        public int? ZaE_MagFirma { get; set; }

        public int? ZaE_MagNumer { get; set; }

        public short? ZaE_MagLp { get; set; }

        public int? ZaE_TStamp { get; set; }

        public decimal? ZaE_Ilosc { get; set; }

        [StringLength(8)]
        public string ZaE_JmZ { get; set; }

        public byte? ZaE_TypJm { get; set; }

        public byte? ZaE_JmFormat { get; set; }

        public byte? ZaE_JmFormatZ { get; set; }

        public decimal? ZaE_PrzeliczM { get; set; }

        public decimal? ZaE_PrzeliczL { get; set; }

        [StringLength(1)]
        public string ZaE_GrupaPod { get; set; }

        public decimal? ZaE_StawkaPod { get; set; }

        public byte? ZaE_FlagaVAT { get; set; }

        public decimal? ZaE_Zrodlowa { get; set; }

        [StringLength(3)]
        public string ZaE_Waluta { get; set; }

        public short? ZaE_NrKursu { get; set; }

        public decimal? ZaE_Rabat { get; set; }

        [StringLength(20)]
        public string ZaE_Cecha { get; set; }

        public decimal? ZaE_CenaKatalogowa { get; set; }

        public decimal? ZaE_CenaOferowana { get; set; }

        public decimal? ZaE_CenaUzgodniona { get; set; }

        public short? ZaE_RodzajCenyBazowej { get; set; }

        public byte? ZaE_ProgTyp { get; set; }

        public decimal? ZaE_Prog { get; set; }

        public byte? ZaE_UpustTyp { get; set; }

        public decimal? ZaE_Upust { get; set; }

        public byte? ZaE_UpustKntTyp { get; set; }

        public decimal? ZaE_UpustKnt { get; set; }

        public short? ZaE_ReETyp { get; set; }

        public int? ZaE_ReEFirma { get; set; }

        public int? ZaE_ReENumer { get; set; }

        public short? ZaE_ReELp { get; set; }

        public short? ZaE_ReEProdLp { get; set; }

        public int? ZaE_DataWaznosciRez { get; set; }

        public decimal? ZaE_WartoscPoRabacie { get; set; }

        public int? ZaE_DataPotwDst { get; set; }

        public int? ZaE_DataAktywacjiRez { get; set; }

        public int? ZaE_DataOdZam { get; set; }

        public byte? ZaE_PrecyzjaCeny { get; set; }

        public byte? ZaE_Rownanie { get; set; }

        [StringLength(1)]
        public string ZaE_FlagaNB { get; set; }

        public short? ZaE_Licencja { get; set; }

        public short? ZaE_Pozycja { get; set; }

        public decimal? ZaE_RabatPromocyjny { get; set; }

        public decimal? ZaE_RabatKorekta { get; set; }

        public int? ZaE_Promocje { get; set; }

        public short? ZaE_ZstTyp { get; set; }

        public int? ZaE_ZstFirma { get; set; }

        public int? ZaE_ZstNumer { get; set; }

        public short? ZaE_ZstLp { get; set; }

        public short? ZaE_PrecyzjaCenyPocz { get; set; }

        public short? ZaE_CenaSpr { get; set; }

        public short? ZaE_RodzajDatyRealizacji { get; set; }

        public decimal? ZaE_KGOJednostkowe { get; set; }

        public int? ZaE_OddElemId { get; set; }

        public decimal? ZaE_IloscMin { get; set; }

        public decimal? ZaE_IloscMax { get; set; }

        public int? ZaE_PakietId { get; set; }

        public short? ZaE_Gratis { get; set; }

        public int? ZaE_PromocjaProgID { get; set; }

        public short? ZaE_Zlom { get; set; }

        public byte? ZaE_FormatkaCyr { get; set; }

        public int? ZaE_KPNId { get; set; }

        public byte? ZaE_TypCenyNabycia { get; set; }

        public virtual ZamNag ZamNag { get; set; }
    }
}
