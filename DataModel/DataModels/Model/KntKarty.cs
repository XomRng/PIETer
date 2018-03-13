namespace DataModels.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CDN.KntKarty")]
    public partial class KntKarty
    {
        public short? Knt_GIDTyp { get; set; }

        public int? Knt_GIDFirma { get; set; }

        [Key]
        public int Knt_GIDNumer { get; set; }

        public short? Knt_GIDLp { get; set; }

        public short? Knt_KnATyp { get; set; }

        public int? Knt_KnAFirma { get; set; }

        public int? Knt_KnANumer { get; set; }

        public short? Knt_KnALp { get; set; }

        public byte? Knt_Typ { get; set; }

        public short? Knt_Akwizytor { get; set; }

        [StringLength(20)]
        public string Knt_Akronim { get; set; }

        [StringLength(30)]
        public string Knt_AkronimFormat { get; set; }

        [StringLength(8)]
        public string Knt_FppKod { get; set; }

        [StringLength(50)]
        public string Knt_Nazwa1 { get; set; }

        [StringLength(50)]
        public string Knt_Nazwa2 { get; set; }

        [StringLength(250)]
        public string Knt_Nazwa3 { get; set; }

        [StringLength(10)]
        public string Knt_KodP { get; set; }

        [StringLength(30)]
        public string Knt_Miasto { get; set; }

        [StringLength(30)]
        public string Knt_Ulica { get; set; }

        [StringLength(30)]
        public string Knt_Adres { get; set; }

        [StringLength(13)]
        public string Knt_NipE { get; set; }

        [StringLength(13)]
        public string Knt_Nip { get; set; }

        [StringLength(2)]
        public string Knt_NipPrefiks { get; set; }

        [StringLength(20)]
        public string Knt_Regon { get; set; }

        [StringLength(11)]
        public string Knt_Pesel { get; set; }

        [StringLength(30)]
        public string Knt_KontoDostawcy { get; set; }

        [StringLength(30)]
        public string Knt_KontoOdbiorcy { get; set; }

        [StringLength(2)]
        public string Knt_Kraj { get; set; }

        [StringLength(30)]
        public string Knt_Powiat { get; set; }

        [StringLength(30)]
        public string Knt_Gmina { get; set; }

        [StringLength(30)]
        public string Knt_Wojewodztwo { get; set; }

        public int? Knt_RegionCRM { get; set; }

        [StringLength(13)]
        public string Knt_GLN { get; set; }

        [StringLength(30)]
        public string Knt_Telefon1 { get; set; }

        [StringLength(30)]
        public string Knt_Telefon2 { get; set; }

        [StringLength(30)]
        public string Knt_Fax { get; set; }

        [StringLength(30)]
        public string Knt_Modem { get; set; }

        [StringLength(30)]
        public string Knt_Telex { get; set; }

        [StringLength(255)]
        public string Knt_EMail { get; set; }

        [StringLength(255)]
        public string Knt_URL { get; set; }

        public short? Knt_BnkTyp { get; set; }

        public int? Knt_BnkFirma { get; set; }

        public int? Knt_BnkNumer { get; set; }

        public short? Knt_BnkLp { get; set; }

        [StringLength(50)]
        public string Knt_NrRachunku { get; set; }

        [StringLength(20)]
        public string Knt_Soundex { get; set; }

        public decimal? Knt_Rabat { get; set; }

        public decimal? Knt_LimitWart { get; set; }

        public decimal? Knt_MaxLimitWart { get; set; }

        public decimal? Knt_LimitPoTerminie { get; set; }

        public short? Knt_LimitOkres { get; set; }

        public byte? Knt_Dewizowe { get; set; }

        [StringLength(3)]
        public string Knt_Symbol { get; set; }

        public short? Knt_NrKursu { get; set; }

        public short? Knt_Cena { get; set; }

        public byte? Knt_FormaPl { get; set; }

        public decimal? Knt_Marza { get; set; }

        public short? Knt_TypKarty { get; set; }

        [StringLength(16)]
        public string Knt_NumerKarty { get; set; }

        public int? Knt_DataKarty { get; set; }

        [StringLength(16)]
        public string Knt_Ean { get; set; }

        public short? Knt_ObcaKarta { get; set; }

        public byte? Knt_Osoba { get; set; }

        public byte? Knt_ExpoKraj { get; set; }

        [StringLength(5)]
        public string Knt_SeriaFa { get; set; }

        public byte? Knt_PlatnikVat { get; set; }

        public short? Knt_TypDok { get; set; }

        public byte? Knt_Status { get; set; }

        public int? Knt_FAVATData { get; set; }

        [StringLength(20)]
        public string Knt_SposobDostawy { get; set; }

        [StringLength(2)]
        public string Knt_HasloChk { get; set; }

        [StringLength(11)]
        public string Knt_HasloKontrahent { get; set; }

        public byte? Knt_Dzialalnosc { get; set; }

        public short? Knt_ZTrTyp { get; set; }

        public int? Knt_ZTrFirma { get; set; }

        public int? Knt_ZTrNumer { get; set; }

        public short? Knt_ZTrLp { get; set; }

        public short? Knt_OpeTyp { get; set; }

        public int? Knt_OpeFirma { get; set; }

        public int? Knt_OpeNumer { get; set; }

        public short? Knt_OpeLp { get; set; }

        public short? Knt_AkwTyp { get; set; }

        public int? Knt_AkwFirma { get; set; }

        public int? Knt_AkwNumer { get; set; }

        public short? Knt_AkwLp { get; set; }

        public short? Knt_PrcTyp { get; set; }

        public int? Knt_PrcFirma { get; set; }

        public int? Knt_PrcNumer { get; set; }

        public short? Knt_PrcLp { get; set; }

        [StringLength(20)]
        public string Knt_Atrybut1 { get; set; }

        public byte? Knt_Format1 { get; set; }

        [StringLength(20)]
        public string Knt_Wartosc1 { get; set; }

        [StringLength(20)]
        public string Knt_Atrybut2 { get; set; }

        public byte? Knt_Format2 { get; set; }

        [StringLength(20)]
        public string Knt_Wartosc2 { get; set; }

        [StringLength(20)]
        public string Knt_Atrybut3 { get; set; }

        public byte? Knt_Format3 { get; set; }

        [StringLength(20)]
        public string Knt_Wartosc3 { get; set; }

        public decimal? Knt_AkwProwizja { get; set; }

        [StringLength(30)]
        public string Knt_Umowa { get; set; }

        public int? Knt_DataW { get; set; }

        public int? Knt_LastModL { get; set; }

        public int? Knt_LastModO { get; set; }

        public int? Knt_LastModC { get; set; }

        [StringLength(30)]
        public string Knt_FaVATOsw { get; set; }

        [StringLength(250)]
        public string Knt_CechaOpis { get; set; }

        public int? Knt_Aktywna { get; set; }

        public byte? Knt_Wsk { get; set; }

        [StringLength(255)]
        public string Knt_OutlookUrl { get; set; }

        public byte? Knt_Nieaktywny { get; set; }

        public int? Knt_Zrodlo { get; set; }

        public int? Knt_Branza { get; set; }

        public int? Knt_Rodzaj { get; set; }

        public int? Knt_RolaPartnera { get; set; }

        public decimal? Knt_Odleglosc { get; set; }

        public short? Knt_KarTyp { get; set; }

        public int? Knt_KarFirma { get; set; }

        public int? Knt_KarNumer { get; set; }

        public short? Knt_KarLp { get; set; }

        public short? Knt_NRB { get; set; }

        public short? Knt_Archiwalny { get; set; }

        public short? Knt_AdresNieAktualny { get; set; }

        public int? Knt_LastTransLockDate { get; set; }

        public short? Knt_OpeTypM { get; set; }

        public int? Knt_OpeFirmaM { get; set; }

        public int? Knt_OpeNumerM { get; set; }

        public short? Knt_OpeLpM { get; set; }

        public short? Knt_BlokadaTransakcji { get; set; }

        public short? Knt_Oddzialowy { get; set; }

        public byte? Knt_Spedytor { get; set; }

        public int? Knt_TerminPlKa { get; set; }

        public int? Knt_FormaPlKa { get; set; }

        public int? Knt_TerminPlZak { get; set; }

        public int? Knt_FormaPlZak { get; set; }

        public int? Knt_SpTerminPlSpr { get; set; }

        public int? Knt_SpTerminPlRK { get; set; }

        public int? Knt_SpTerminPlZak { get; set; }

        public short? Knt_LimitTerminowy { get; set; }

        public int? Knt_DataWygasniecia { get; set; }

        [StringLength(4)]
        public string Knt_PIN { get; set; }

        public int? Knt_Priorytet { get; set; }

        public int? Knt_FrsID { get; set; }

        public byte? Knt_Controlling { get; set; }

        public byte? Knt_RolnikRyczaltowy { get; set; }

        public byte? Knt_PriorytetRez { get; set; }

        public byte? Knt_Powiazany { get; set; }

        public byte? Knt_PlatnoscKaucji { get; set; }

        public int? Knt_TerminRozliczeniaKaucji { get; set; }

        public short? Knt_KnPTyp { get; set; }

        public int? Knt_KnPNumer { get; set; }

        public byte? Knt_KnPParam { get; set; }

        public int? Knt_DataUtworzenia { get; set; }

        [StringLength(50)]
        public string Knt_DokumentTozsamosci { get; set; }

        public int? Knt_DataWydania { get; set; }

        [StringLength(50)]
        public string Knt_OrganWydajacy { get; set; }

        public int? Knt_MaxDniPoTerminie { get; set; }

        public int? Knt_KalendarzDst { get; set; }

        public int? Knt_KalendarzWys { get; set; }

        public short? Knt_KnGTyp { get; set; }

        public int? Knt_KnGNumer { get; set; }

        public decimal? Knt_Punkty { get; set; }

        public short? Knt_KnCTyp { get; set; }

        public int? Knt_KnCNumer { get; set; }

        public byte? Knt_EFaVatAktywne { get; set; }

        [StringLength(30)]
        public string Knt_EFaVatOsw { get; set; }

        public int? Knt_EFaVatDataDo { get; set; }

        [StringLength(255)]
        public string Knt_EFaVatEMail { get; set; }

        public byte? Knt_PodatnikiemNabywca { get; set; }

        public int? Knt_MSTwrGrupaNumer { get; set; }

        public byte? Knt_StanPostep { get; set; }

        public byte? Knt_ESklep { get; set; }
    }
}
