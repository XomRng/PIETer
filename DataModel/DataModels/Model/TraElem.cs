namespace DataModels.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CDN.TraElem")]
    public partial class TraElem
    {
        public short? TrE_GIDTyp { get; set; }

        public int? TrE_GIDFirma { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TrE_GIDNumer { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short TrE_GIDLp { get; set; }

        public short? TrE_Pozycja { get; set; }

        public short? TrE_TwrTyp { get; set; }

        public int? TrE_TwrFirma { get; set; }

        public int? TrE_TwrNumer { get; set; }

        public short? TrE_TwrLp { get; set; }

        [StringLength(255)]
        public string TrE_TwrNazwa { get; set; }

        [StringLength(40)]
        public string TrE_TwrKod { get; set; }

        public byte? TrE_TypTwr { get; set; }

        public short? TrE_KntTyp { get; set; }

        public int? TrE_KntFirma { get; set; }

        public int? TrE_KntNumer { get; set; }

        public short? TrE_KntLp { get; set; }

        public short? TrE_AkwTyp { get; set; }

        public int? TrE_AkwFirma { get; set; }

        public int? TrE_AkwNumer { get; set; }

        public short? TrE_AkwLp { get; set; }

        public int? TrE_TrnTStamp { get; set; }

        public decimal? TrE_Punkty { get; set; }

        public decimal? TrE_Ilosc { get; set; }

        public byte? TrE_JmFormat { get; set; }

        [StringLength(8)]
        public string TrE_JmZ { get; set; }

        public byte? TrE_JmFormatZ { get; set; }

        public byte? TrE_TypJm { get; set; }

        public decimal? TrE_PrzeliczM { get; set; }

        public decimal? TrE_PrzeliczL { get; set; }

        [StringLength(1)]
        public string TrE_GrupaPod { get; set; }

        public decimal? TrE_StawkaPod { get; set; }

        public byte? TrE_FlagaVat { get; set; }

        public decimal? TrE_Zrodlowa { get; set; }

        public decimal? TrE_Akcyza { get; set; }

        [StringLength(3)]
        public string TrE_Waluta { get; set; }

        public short? TrE_NrKursu { get; set; }

        public decimal? TrE_KursM { get; set; }

        public decimal? TrE_KursL { get; set; }

        public decimal? TrE_Poczatkowa { get; set; }

        [StringLength(1)]
        public string TrE_FlagaNB { get; set; }

        public decimal? TrE_Rabat { get; set; }

        public decimal? TrE_WartoscPoRabacie { get; set; }

        public decimal? TrE_KsiegowaNetto { get; set; }

        public decimal? TrE_KsiegowaBrutto { get; set; }

        public decimal? TrE_RzeczywistaNetto { get; set; }

        public decimal? TrE_KosztKsiegowy { get; set; }

        public decimal? TrE_KosztRzeczywisty { get; set; }

        public byte? TrE_ProgTyp { get; set; }

        public decimal? TrE_Prog { get; set; }

        public byte? TrE_UpustTyp { get; set; }

        public decimal? TrE_Upust { get; set; }

        public decimal? TrE_UpustKnt { get; set; }

        public byte? TrE_UpustKntTyp { get; set; }

        public decimal? TrE_IloscDPPrzed { get; set; }

        public decimal? TrE_KsiegowyDPPrzed { get; set; }

        public short? TrE_ZlcTyp { get; set; }

        public int? TrE_ZlcFirma { get; set; }

        public int? TrE_ZlcNumer { get; set; }

        public short? TrE_ZlcLp { get; set; }

        public short? TrE_RecTyp { get; set; }

        public int? TrE_RecFirma { get; set; }

        public int? TrE_RecNumer { get; set; }

        public short? TrE_RecLp { get; set; }

        public decimal? TrE_Cena { get; set; }

        public byte? TrE_Rownanie { get; set; }

        public byte? TrE_OdKsiegowych { get; set; }

        public decimal? TrE_RzeczywistyDPPrzed { get; set; }

        [StringLength(10)]
        public string TrE_PCN { get; set; }

        public byte? TrE_PrecyzjaCeny { get; set; }

        public short? TrE_VatTyp { get; set; }

        public int? TrE_VatFirma { get; set; }

        public int? TrE_VatNumer { get; set; }

        public short? TrE_VatLp { get; set; }

        public byte? TrE_KosztVat { get; set; }

        public byte? TrE_KosztNetto { get; set; }

        public short? TrE_Licencja { get; set; }

        [StringLength(2)]
        public string TrE_KrajPoch { get; set; }

        public decimal? TrE_RabatPromocyjny { get; set; }

        public decimal? TrE_RabatKorekta { get; set; }

        public int? TrE_Promocje { get; set; }

        public short? TrE_ZstTyp { get; set; }

        public int? TrE_ZstFirma { get; set; }

        public int? TrE_ZstNumer { get; set; }

        public short? TrE_ZstLp { get; set; }

        public byte? TrE_PrecyzjaCenyPocz { get; set; }

        public byte? TrE_ZwroconoCalaIlosc { get; set; }

        public short? TrE_RodzajCenyBazowej { get; set; }

        public decimal? TrE_KosztBazowy { get; set; }

        public decimal? TrE_WartoscBazowa { get; set; }

        public short? TrE_CenaSpr { get; set; }

        public decimal? TrE_CenaPoRabacie { get; set; }

        public short? TrE_CChTyp { get; set; }

        public int? TrE_CChNumer { get; set; }

        [StringLength(20)]
        public string TrE_Cecha { get; set; }

        public decimal? TrE_KGOJednostkowe { get; set; }

        public decimal? TrE_IloscMin { get; set; }

        public decimal? TrE_IloscMax { get; set; }

        public int? TrE_PakietId { get; set; }

        public short? TrE_Gratis { get; set; }

        public int? TrE_PromocjaProgID { get; set; }

        public byte? TrE_FormatkaCyr { get; set; }

        public short? TrE_Zlom { get; set; }

        public decimal? TrE_IloscPrzedKorekta { get; set; }

        public decimal? TrE_CenaPrzedKorekta { get; set; }

        public decimal? TrE_WartoscPrzedKorekta { get; set; }

        [StringLength(1)]
        public string TrE_GrupaPodPrzedKorekta { get; set; }

        public decimal? TrE_StawkaPodPrzedKorekta { get; set; }

        public byte? TrE_FlagaVatPrzedKorekta { get; set; }

        public decimal? TrE_ZrodlowaPrzedKorekta { get; set; }

        public decimal? TrE_AkcyzaPrzedKorekta { get; set; }

        [StringLength(255)]
        public string TrE_PrzyczynaKorekty { get; set; }

        public byte? TrE_KatDatyOP { get; set; }

        public int? TrE_RodzajKosztu { get; set; }

        public virtual TraNag TraNag { get; set; }
    }
}
