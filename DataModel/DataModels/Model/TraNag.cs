namespace DataModels.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CDN.TraNag")]
    public partial class TraNag
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TraNag()
        {
            TraElem = new HashSet<TraElem>();
        }

        public short? TrN_GIDTyp { get; set; }

        public int? TrN_GIDFirma { get; set; }

        [Key]
        public int TrN_GIDNumer { get; set; }

        public short? TrN_GIDLp { get; set; }

        public short? TrN_ZwrTyp { get; set; }

        public int? TrN_ZwrFirma { get; set; }

        public int? TrN_ZwrNumer { get; set; }

        public short? TrN_ZwrLp { get; set; }

        public short? TrN_SpiTyp { get; set; }

        public int? TrN_SpiFirma { get; set; }

        public int? TrN_SpiNumer { get; set; }

        public short? TrN_SpiLp { get; set; }

        public short? TrN_RelTyp { get; set; }

        public int? TrN_RelFirma { get; set; }

        public int? TrN_RelNumer { get; set; }

        public short? TrN_RelLp { get; set; }

        public short? TrN_KntTyp { get; set; }

        public int? TrN_KntFirma { get; set; }

        public int? TrN_KntNumer { get; set; }

        public short? TrN_KntLp { get; set; }

        public short? TrN_KnATyp { get; set; }

        public int? TrN_KnAFirma { get; set; }

        public int? TrN_KnANumer { get; set; }

        public short? TrN_KnALp { get; set; }

        public short? TrN_AkwTyp { get; set; }

        public int? TrN_AkwFirma { get; set; }

        public int? TrN_AkwNumer { get; set; }

        public short? TrN_AkwLp { get; set; }

        public short? TrN_AdWTyp { get; set; }

        public int? TrN_AdWFirma { get; set; }

        public int? TrN_AdWNumer { get; set; }

        public short? TrN_AdWLp { get; set; }

        public short? TrN_SchTyp { get; set; }

        public int? TrN_SchFirma { get; set; }

        public int? TrN_SchNumer { get; set; }

        public short? TrN_SchLp { get; set; }

        public short? TrN_ZaNTyp { get; set; }

        public int? TrN_ZaNFirma { get; set; }

        public int? TrN_ZaNNumer { get; set; }

        public short? TrN_ZaNLp { get; set; }

        public short? TrN_SaNTyp { get; set; }

        public int? TrN_SaNFirma { get; set; }

        public int? TrN_SaNNumer { get; set; }

        public short? TrN_SaNLp { get; set; }

        public short? TrN_KonTyp { get; set; }

        public int? TrN_KonFirma { get; set; }

        public int? TrN_KonNumer { get; set; }

        public short? TrN_KonLp { get; set; }

        public short? TrN_TKTyp { get; set; }

        public int? TrN_TKFirma { get; set; }

        public int? TrN_TKNumer { get; set; }

        public short? TrN_TKLp { get; set; }

        [StringLength(5)]
        public string TrN_Dziennik { get; set; }

        public int? TrN_Data2 { get; set; }

        public int? TrN_Data3 { get; set; }

        public short? TrN_TrNTyp { get; set; }

        public short? TrN_TrNRok { get; set; }

        public byte? TrN_TrNMiesiac { get; set; }

        [StringLength(5)]
        public string TrN_TrNSeria { get; set; }

        public int? TrN_TrNNumer { get; set; }

        public short? TrN_TrNLp { get; set; }

        public short? TrN_VatTyp { get; set; }

        [StringLength(5)]
        public string TrN_VatRejestr { get; set; }

        public short? TrN_VatRok { get; set; }

        public short? TrN_VatMiesiac { get; set; }

        public short? TrN_VatDzien { get; set; }

        public int? TrN_VatNumer { get; set; }

        public byte? TrN_VatKorekta { get; set; }

        public short? TrN_DeklRok { get; set; }

        public short? TrN_DeklMiesiac { get; set; }

        public byte? TrN_Rozliczac { get; set; }

        [StringLength(40)]
        public string TrN_DokumentObcy { get; set; }

        [StringLength(40)]
        public string TrN_ZamDokumentObcy { get; set; }

        [StringLength(40)]
        public string TrN_NrKorekty { get; set; }

        public byte? TrN_OdliczeniaVat { get; set; }

        public byte? TrN_RodzajZakupu { get; set; }

        public byte? TrN_ExpoNorm { get; set; }

        public byte? TrN_Detal { get; set; }

        [StringLength(1)]
        public string TrN_FlagaNB { get; set; }

        public short? TrN_CenaSpr { get; set; }

        public byte? TrN_Fiskalny { get; set; }

        public byte? TrN_FormaNr { get; set; }

        [StringLength(15)]
        public string TrN_FormaNazwa { get; set; }

        public decimal? TrN_FormaRabat { get; set; }

        public decimal? TrN_Rabat { get; set; }

        public decimal? TrN_Zaokraglenie { get; set; }

        public byte? TrN_Zaksiegowano { get; set; }

        public short? TrN_Stan { get; set; }

        public short? TrN_LicznikKopii { get; set; }

        [StringLength(20)]
        public string TrN_SposobDostawy { get; set; }

        public short? TrN_MagZTyp { get; set; }

        public int? TrN_MagZFirma { get; set; }

        public int? TrN_MagZNumer { get; set; }

        public short? TrN_MagZLp { get; set; }

        public short? TrN_MagDTyp { get; set; }

        public int? TrN_MagDFirma { get; set; }

        public int? TrN_MagDNumer { get; set; }

        public short? TrN_MagDLp { get; set; }

        public short? TrN_OpeTypW { get; set; }

        public int? TrN_OpeFirmaW { get; set; }

        public int? TrN_OpeNumerW { get; set; }

        public short? TrN_OpeLpW { get; set; }

        public short? TrN_OpeTypZ { get; set; }

        public int? TrN_OpeFirmaZ { get; set; }

        public int? TrN_OpeNumerZ { get; set; }

        public short? TrN_OpeLpZ { get; set; }

        public short? TrN_OpeTypR { get; set; }

        public int? TrN_OpeFirmaR { get; set; }

        public int? TrN_OpeNumerR { get; set; }

        public short? TrN_OpeLpR { get; set; }

        public short? TrN_OdoTyp { get; set; }

        public int? TrN_OdoFirma { get; set; }

        public int? TrN_OdoNumer { get; set; }

        public short? TrN_OdoLp { get; set; }

        [StringLength(3)]
        public string TrN_Waluta { get; set; }

        public short? TrN_NrKursu { get; set; }

        public decimal? TrN_KursM { get; set; }

        public decimal? TrN_KursL { get; set; }

        public decimal? TrN_NettoR { get; set; }

        public decimal? TrN_NettoP { get; set; }

        public decimal? TrN_VatR { get; set; }

        public decimal? TrN_VatP { get; set; }

        public int? TrN_FrsID { get; set; }

        [StringLength(250)]
        public string TrN_CechaOpis { get; set; }

        public int? TrN_RokMiesiac { get; set; }

        public int? TrN_Aktywny { get; set; }

        public byte? TrN_Wsk { get; set; }

        public short? TrN_KarTyp { get; set; }

        public int? TrN_KarFirma { get; set; }

        public int? TrN_KarNumer { get; set; }

        public short? TrN_KarLp { get; set; }

        public short? TrN_KnDTyp { get; set; }

        public int? TrN_KnDFirma { get; set; }

        public int? TrN_KnDNumer { get; set; }

        public short? TrN_KnDLp { get; set; }

        public byte? TrN_TypSumyPlatnosci { get; set; }

        public decimal? TrN_WartoscDPPrzed { get; set; }

        public decimal? TrN_WartoscDPPo { get; set; }

        public byte? TrN_ZmodyfikowanoZasob { get; set; }

        [StringLength(255)]
        public string TrN_Url { get; set; }

        public decimal? TrN_RabatW { get; set; }

        public int? TrN_Termin { get; set; }

        public int? TrN_DataWystOrg { get; set; }

        public int? TrN_DataSprOrg { get; set; }

        public int? TrN_FiaskoID { get; set; }

        [StringLength(255)]
        public string TrN_MiejsceZaladunku { get; set; }

        [StringLength(255)]
        public string TrN_MiejscePrzeznaczenia { get; set; }

        [StringLength(255)]
        public string TrN_RodzajTransportu { get; set; }

        public int? TrN_DataWysylki { get; set; }

        [StringLength(2000)]
        public string TrN_InfoDlaUC { get; set; }

        public decimal? TrN_Waga { get; set; }

        [StringLength(5)]
        public string TrN_WJm { get; set; }

        [StringLength(30)]
        public string TrN_NumerSAD { get; set; }

        public decimal? TrN_WartoscWal { get; set; }

        public short? TrN_OpeTypM { get; set; }

        public int? TrN_OpeFirmaM { get; set; }

        public int? TrN_OpeNumerM { get; set; }

        public short? TrN_OpeLpM { get; set; }

        public byte? TrN_TypEdycjiVat { get; set; }

        [StringLength(4)]
        public string TrN_IncotermsSymbol { get; set; }

        [StringLength(255)]
        public string TrN_IncotermsMiejsce { get; set; }

        public decimal? TrN_WagaBrutto { get; set; }

        public int? TrN_OddDokId { get; set; }

        public int? TrN_DataOdb { get; set; }

        public int? TrN_DataRoz { get; set; }

        public short? TrN_OpiTyp { get; set; }

        public int? TrN_OpiFirma { get; set; }

        public int? TrN_OpiNumer { get; set; }

        public short? TrN_OpiLp { get; set; }

        [StringLength(2)]
        public string TrN_KrajPrzezWys { get; set; }

        [StringLength(2)]
        public string TrN_KodRodzajuTransportu { get; set; }

        [StringLength(2)]
        public string TrN_KodRodzajuTransakcji { get; set; }

        public byte? TrN_RolnikRyczalt { get; set; }

        public byte? TrN_RozliczacP { get; set; }

        public byte? TrN_KorektaOdlicz { get; set; }

        public byte? TrN_Struktura { get; set; }

        public byte? TrN_Wyslano { get; set; }

        public short? TrN_NrKursuPierw { get; set; }

        public decimal? TrN_KursMPierw { get; set; }

        public decimal? TrN_KursLPierw { get; set; }

        public int? TrN_Promocje { get; set; }

        public int? TrN_DataMag { get; set; }

        public int? TrN_DataOdprawyPotwierdzenia { get; set; }

        public byte? TrN_PotwierdzenieOdbioru { get; set; }

        public decimal? TrN_RabatPromocyjnyGlobalny { get; set; }

        public byte? TrN_Platnosci { get; set; }

        public byte? TrN_ZwroconoCalaIlosc { get; set; }

        public int? TrN_TerminRozliczeniaKaucji { get; set; }

        public short? TrN_KnPTyp { get; set; }

        public int? TrN_KnPNumer { get; set; }

        public int? TrN_AdPNumer { get; set; }

        public int? TrN_LastMod { get; set; }

        public short? TrN_OddZakazPAFA { get; set; }

        public byte? TrN_AktualizujKaucje { get; set; }

        public int? TrN_StRIdW { get; set; }

        public short? TrN_WsSCHTyp { get; set; }

        public int? TrN_WsSCHNumer { get; set; }

        public byte? TrN_WsStosujSchemat { get; set; }

        [StringLength(5)]
        public string TrN_WsDziennik { get; set; }

        public byte? TrN_WsStosujDziennik { get; set; }

        public byte? TrN_KosztUstalono { get; set; }

        public int? TrN_Zrodlo { get; set; }

        public byte? TrN_Intrastat { get; set; }

        public short? TrN_IstRok { get; set; }

        public short? TrN_IstMiesiac { get; set; }

        public int? TrN_PrjId { get; set; }

        public short? TrN_KnSTypD { get; set; }

        public int? TrN_KnSFirmaD { get; set; }

        public int? TrN_KnSNumerD { get; set; }

        public short? TrN_KnSLpD { get; set; }

        public short? TrN_KnSTypP { get; set; }

        public int? TrN_KnSFirmaP { get; set; }

        public int? TrN_KnSNumerP { get; set; }

        public short? TrN_KnSLpP { get; set; }

        public int? TrN_GodzinaWystawienia { get; set; }

        public int? TrN_FrmNumer { get; set; }

        public short? TrN_StanDokMag { get; set; }

        public short? TrN_GenDokMag { get; set; }

        public byte? TrN_PromocjePar { get; set; }

        public byte? TrN_PrzywracajRezerwacje { get; set; }

        public byte? TrN_FormatkaCyr { get; set; }

        public int? TrN_ZewnetrznySys { get; set; }

        public int? TrN_WtrID { get; set; }

        public int? TrN_WtrProgID { get; set; }

        public byte? TrN_TypDatyKor { get; set; }

        public int? TrN_DataOdKor { get; set; }

        public int? TrN_DataDoKor { get; set; }

        public byte? TrN_RodzajKor { get; set; }

        public int? TrN_VatZDPeDNumer { get; set; }

        public short? TrN_VatZDPeDLp { get; set; }

        [StringLength(255)]
        public string TrN_PrzyczynaKorekty { get; set; }

        public byte? TrN_KatDatyOP { get; set; }

        public int? TrN_DataPO { get; set; }

        public int? TrN_DataDostawy { get; set; }

        public int? TrN_NumerRaportu { get; set; }

        public int? TrN_NumerFiskalny { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TraElem> TraElem { get; set; }
    }
}
