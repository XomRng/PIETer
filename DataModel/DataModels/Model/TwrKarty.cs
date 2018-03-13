namespace DataModels.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CDN.TwrKarty")]
    public partial class TwrKarty
    {
        public short? Twr_GIDTyp { get; set; }

        public int? Twr_GIDFirma { get; set; }

        [Key]
        public int Twr_GIDNumer { get; set; }

        public short? Twr_GIDLp { get; set; }

        public byte? Twr_Typ { get; set; }

        [StringLength(40)]
        public string Twr_Kod { get; set; }

        [StringLength(50)]
        public string Twr_KodFormat { get; set; }

        [StringLength(20)]
        public string Twr_FPPKod { get; set; }

        [StringLength(255)]
        public string Twr_Nazwa { get; set; }

        [StringLength(255)]
        public string Twr_Nazwa1 { get; set; }

        [StringLength(60)]
        public string Twr_Certyfikat { get; set; }

        [StringLength(20)]
        public string Twr_Sww { get; set; }

        [StringLength(40)]
        public string Twr_Ean { get; set; }

        [StringLength(8)]
        public string Twr_Jm { get; set; }

        public decimal? Twr_Waga { get; set; }

        [StringLength(5)]
        public string Twr_WJm { get; set; }

        public byte? Twr_JmFormat { get; set; }

        public decimal? Twr_IloscZam { get; set; }

        public decimal? Twr_IloscMin { get; set; }

        public decimal? Twr_IloscMax { get; set; }

        public decimal? Twr_Ubytek { get; set; }

        public byte? Twr_Prog { get; set; }

        public byte? Twr_Upust { get; set; }

        public byte? Twr_UpustData { get; set; }

        public int? Twr_UpustDataOd { get; set; }

        public int? Twr_UpustDataDo { get; set; }

        public byte? Twr_UpustGodz { get; set; }

        public int? Twr_UpustGodzOd { get; set; }

        public int? Twr_UpustGodzDo { get; set; }

        public byte? Twr_AutoZam { get; set; }

        public decimal? Twr_IloscAZam { get; set; }

        public int? Twr_CzasDst { get; set; }

        public short? Twr_CenaSpr { get; set; }

        public short? Twr_JmDomyslna { get; set; }

        public short? Twr_DstDomyslny { get; set; }

        public byte? Twr_RozliczMag { get; set; }

        public byte? Twr_Zakup { get; set; }

        public byte? Twr_Sprzedaz { get; set; }

        [StringLength(1)]
        public string Twr_GrupaPod { get; set; }

        public decimal? Twr_Akcyza { get; set; }

        public short? Twr_OpeTyp { get; set; }

        public int? Twr_OpeFirma { get; set; }

        public int? Twr_OpeNumer { get; set; }

        public short? Twr_OpeLp { get; set; }

        public short? Twr_PrcTyp { get; set; }

        public int? Twr_PrcFirma { get; set; }

        public int? Twr_PrcNumer { get; set; }

        public short? Twr_PrcLp { get; set; }

        public byte? Twr_KontaktTyp { get; set; }

        public short? Twr_KontaktZa { get; set; }

        public byte? Twr_KontaktJC { get; set; }

        public byte? Twr_Okresowy { get; set; }

        [StringLength(200)]
        public string Twr_Cel { get; set; }

        [StringLength(20)]
        public string Twr_Atrybut1 { get; set; }

        public byte? Twr_Format1 { get; set; }

        [StringLength(20)]
        public string Twr_Wartosc1 { get; set; }

        [StringLength(20)]
        public string Twr_Atrybut2 { get; set; }

        public byte? Twr_Format2 { get; set; }

        [StringLength(20)]
        public string Twr_Wartosc2 { get; set; }

        [StringLength(20)]
        public string Twr_Atrybut3 { get; set; }

        public byte? Twr_Format3 { get; set; }

        [StringLength(20)]
        public string Twr_Wartosc3 { get; set; }

        public decimal? Twr_Punkty { get; set; }

        public int? Twr_Koncesja { get; set; }

        [StringLength(30)]
        public string Twr_Konto1 { get; set; }

        [StringLength(30)]
        public string Twr_Konto2 { get; set; }

        [StringLength(30)]
        public string Twr_Konto3 { get; set; }

        [StringLength(64)]
        public string Twr_Polozenie { get; set; }

        [StringLength(40)]
        public string Twr_Katalog { get; set; }

        public byte? Twr_WCenniku { get; set; }

        public byte? Twr_EdycjaNazwy { get; set; }

        public byte? Twr_BezRabatu { get; set; }

        public byte? Twr_KopiujOpis { get; set; }

        [StringLength(255)]
        public string Twr_URL { get; set; }

        [StringLength(255)]
        public string Twr_Warunek { get; set; }

        public decimal? Twr_ObjetoscL { get; set; }

        public decimal? Twr_ObjetoscM { get; set; }

        public int? Twr_LastModL { get; set; }

        public int? Twr_LastModO { get; set; }

        public int? Twr_LastModC { get; set; }

        public int? Twr_TerminZwrotu { get; set; }

        public byte? Twr_ZakupAutoryz { get; set; }

        public short? Twr_MagTyp { get; set; }

        public int? Twr_MagFirma { get; set; }

        public int? Twr_MagNumer { get; set; }

        public short? Twr_MagLp { get; set; }

        public decimal? Twr_MarzaMin { get; set; }

        public decimal? Twr_KosztUslugi { get; set; }

        public byte? Twr_KosztUTyp { get; set; }

        public int? Twr_CzasWykonania { get; set; }

        public byte? Twr_CzasWykonaniaJedn { get; set; }

        public decimal? Twr_Clo { get; set; }

        public decimal? Twr_PodatekImp { get; set; }

        public byte? Twr_StanInfoLimit { get; set; }

        public decimal? Twr_StanInfoMax { get; set; }

        public decimal? Twr_StanInfoProcent { get; set; }

        public int? Twr_Aktywna { get; set; }

        public byte? Twr_Wsk { get; set; }

        public short? Twr_CCKTyp { get; set; }

        public int? Twr_CCKFirma { get; set; }

        public int? Twr_CCKNumer { get; set; }

        public short? Twr_CCKLp { get; set; }

        public short? Twr_PrdTyp { get; set; }

        public int? Twr_PrdFirma { get; set; }

        public int? Twr_PrdNumer { get; set; }

        public short? Twr_PrdLp { get; set; }

        public short? Twr_OpeTypM { get; set; }

        public int? Twr_OpeFirmaM { get; set; }

        public int? Twr_OpeNumerM { get; set; }

        public short? Twr_OpeLpM { get; set; }

        [StringLength(10)]
        public string Twr_PCN { get; set; }

        public int? Twr_Notowania { get; set; }

        public decimal? Twr_WagaBrutto { get; set; }

        [StringLength(5)]
        public string Twr_WJmBrutto { get; set; }

        public decimal? Twr_StawkaPod { get; set; }

        public byte? Twr_FlagaVat { get; set; }

        public decimal? Twr_Zrodlowa { get; set; }

        [StringLength(1)]
        public string Twr_GrupaPodSpr { get; set; }

        public decimal? Twr_StawkaPodSpr { get; set; }

        public byte? Twr_FlagaVatSpr { get; set; }

        public decimal? Twr_ZrodlowaSpr { get; set; }

        public short? Twr_Licencja { get; set; }

        public short? Twr_Blokada { get; set; }

        public short? Twr_Archiwalny { get; set; }

        public byte? Twr_JMCalkowita { get; set; }

        public short? Twr_Oddzialowy { get; set; }

        public short? Twr_JmDomyslnaZak { get; set; }

        [StringLength(2)]
        public string Twr_KrajPoch { get; set; }

        public decimal? Twr_WspFin { get; set; }

        public byte? Twr_PobierzWgCech { get; set; }

        public byte? Twr_Kaucja { get; set; }

        public int? Twr_SkNId { get; set; }

        public byte? Twr_RejWyposazenia { get; set; }

        public int? Twr_OkresGwarancji { get; set; }

        public int? Twr_GrupaWyposazenia { get; set; }

        public int? Twr_ProdTechnologia { get; set; }

        public byte? Twr_ProdAktualnaWersja { get; set; }

        public byte? Twr_TwZOdNajwiekszego { get; set; }

        public int? Twr_DataUtworzenia { get; set; }

        [StringLength(5)]
        public string Twr_WymJm { get; set; }

        public byte? Twr_PartiaDataW { get; set; }

        public short? Twr_TerminW { get; set; }

        public byte? Twr_PartiaDostawa { get; set; }

        public byte? Twr_NrSeryjnyZCechy { get; set; }

        public byte? Twr_ESklep { get; set; }

        public int? Twr_StawkaKGO { get; set; }

        public byte? Twr_DostawaEAN { get; set; }

        public int? Twr_MarkaId { get; set; }

        public byte? Twr_RejestrujUrzadzenie { get; set; }

        public int? Twr_RodzajUrzadzenia { get; set; }

        [StringLength(511)]
        public string Twr_OpisUrzadzenia { get; set; }

        [StringLength(2)]
        public string Twr_KategoriaABCXYZ { get; set; }

        public int? Twr_RodzajId { get; set; }

        public byte? Twr_MobSpr { get; set; }

        public byte? Twr_PLM { get; set; }

        public byte? Twr_JMBlokujZmiane { get; set; }

        public byte? Twr_AnalizaABCXYZ { get; set; }

        public byte? Twr_Zlom { get; set; }

        public int? Twr_JMiSklep { get; set; }

        public int? Twr_JMPulpitKnt { get; set; }

        public short? Twr_JMMobSpr { get; set; }

        public int? Twr_PIADostepnoscFlaga { get; set; }

        public int? Twr_ObowPodSprId { get; set; }

        public int? Twr_ObowPodZakId { get; set; }

        public int? Twr_RodzajKosztu { get; set; }

        public short? Twr_JMDopelnianiaMobSpr { get; set; }

        [StringLength(255)]
        public string Twr_Techniczna1 { get; set; }

        [StringLength(255)]
        public string Twr_Techniczna2 { get; set; }

        [StringLength(255)]
        public string Twr_Techniczna3 { get; set; }

        [StringLength(255)]
        public string Twr_Techniczna4 { get; set; }
    }
}
