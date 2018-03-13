namespace DataModels.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CDN.ZamNag")]
    public partial class ZamNag
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ZamNag()
        {
            ZamElem = new HashSet<ZamElem>();
        }

        public short? ZaN_GIDTyp { get; set; }

        public int? ZaN_GIDFirma { get; set; }

        [Key]
        public int ZaN_GIDNumer { get; set; }

        public short? ZaN_GIDLp { get; set; }

        public short? ZaN_ZrdTyp { get; set; }

        public int? ZaN_ZrdFirma { get; set; }

        public int? ZaN_ZrdNumer { get; set; }

        public short? ZaN_ZrdLp { get; set; }

        public short? ZaN_KorTyp { get; set; }

        public int? ZaN_KorFirma { get; set; }

        public int? ZaN_KorNumer { get; set; }

        public short? ZaN_KorLp { get; set; }

        public short? ZaN_KntTyp { get; set; }

        public int? ZaN_KntFirma { get; set; }

        public int? ZaN_KntNumer { get; set; }

        public short? ZaN_KntLp { get; set; }

        public short? ZaN_KnATyp { get; set; }

        public int? ZaN_KnAFirma { get; set; }

        public int? ZaN_KnANumer { get; set; }

        public short? ZaN_KnALp { get; set; }

        public short? ZaN_AkwTyp { get; set; }

        public int? ZaN_AkwFirma { get; set; }

        public int? ZaN_AkwNumer { get; set; }

        public short? ZaN_AkwLp { get; set; }

        public short? ZaN_AdWTyp { get; set; }

        public int? ZaN_AdwFirma { get; set; }

        public int? ZaN_AdWNumer { get; set; }

        public short? ZaN_AdWLp { get; set; }

        public short? ZaN_MagTyp { get; set; }

        public int? ZaN_MagFirma { get; set; }

        public int? ZaN_MagNumer { get; set; }

        public short? ZaN_MagLp { get; set; }

        public byte? ZaN_FormaNr { get; set; }

        [StringLength(15)]
        public string ZaN_FormaNazwa { get; set; }

        public decimal? ZaN_FormaRabat { get; set; }

        public int? ZaN_TerminPlatnosci { get; set; }

        public short? ZaN_ZamTyp { get; set; }

        public short? ZaN_ZamRok { get; set; }

        public byte? ZaN_ZamMiesiac { get; set; }

        [StringLength(5)]
        public string ZaN_ZamSeria { get; set; }

        public int? ZaN_ZamNumer { get; set; }

        public short? ZaN_ZamLp { get; set; }

        public short? ZaN_PomTyp { get; set; }

        public short? ZaN_PomRok { get; set; }

        public byte? ZaN_PomMiesiac { get; set; }

        [StringLength(5)]
        public string ZaN_PomSeria { get; set; }

        public int? ZaN_PomNumer { get; set; }

        public short? ZaN_PomLp { get; set; }

        [StringLength(40)]
        public string ZaN_DokumentObcy { get; set; }

        [StringLength(40)]
        public string ZaN_DokumentObcyP { get; set; }

        public byte? ZaN_ExpoNorm { get; set; }

        [StringLength(3)]
        public string ZaN_Waluta { get; set; }

        public short? ZaN_NrKursu { get; set; }

        public decimal? ZaN_KursM { get; set; }

        public decimal? ZaN_KursL { get; set; }

        public byte? ZaN_TypKursu { get; set; }

        public byte ZaN_WspolnaWaluta { get; set; }

        public short? ZaN_OpeTypW { get; set; }

        public int? ZaN_OpeFirmaW { get; set; }

        public int? ZaN_OpeNumerW { get; set; }

        public short? ZaN_OpeLpW { get; set; }

        public short? ZaN_OpeTypM { get; set; }

        public int? ZaN_OpeFirmaM { get; set; }

        public int? ZaN_OpeNumerM { get; set; }

        public short? ZaN_OpeLpM { get; set; }

        public short? ZaN_OpeTypZ { get; set; }

        public int? ZaN_OpeFirmaZ { get; set; }

        public int? ZaN_OpeNumerZ { get; set; }

        public short? ZaN_OpeLpZ { get; set; }

        public short? ZaN_OpeTypP { get; set; }

        public int? ZaN_OpeFirmaP { get; set; }

        public int? ZaN_OpeNumerP { get; set; }

        public short? ZaN_OpeLpP { get; set; }

        public int? ZaN_ID { get; set; }

        public decimal? ZaN_Rabat { get; set; }

        public byte? ZaN_TypRabatu { get; set; }

        [StringLength(20)]
        public string ZaN_SpDostawy { get; set; }

        [StringLength(250)]
        public string ZaN_CechaOpis { get; set; }

        public int? ZaN_DataZapytania { get; set; }

        public byte? ZaN_RealWCalosci { get; set; }

        public int? ZaN_DataWystawienia { get; set; }

        public int? ZaN_DataRealizacji { get; set; }

        public int? ZaN_DataWaznosci { get; set; }

        public int? ZaN_DataPotwierdz { get; set; }

        public int? ZaN_DataAkceptacji { get; set; }

        public int? ZaN_DataOdZam { get; set; }

        public short? ZaN_Stan { get; set; }

        public int? ZaN_Aktywny { get; set; }

        public byte? ZaN_DokZwiazane { get; set; }

        public byte? ZaN_LKopii { get; set; }

        public byte? ZaN_Wsk { get; set; }

        public short? ZaN_KnSTyp { get; set; }

        public int? ZaN_KnSFirma { get; set; }

        public int? ZaN_KnSNumer { get; set; }

        public short? ZaN_KnSLp { get; set; }

        public short? ZaN_KnSTypP { get; set; }

        public int? ZaN_KnSFirmaP { get; set; }

        public int? ZaN_KnSNumerP { get; set; }

        public short? ZaN_KnSLpP { get; set; }

        public short? ZaN_Rodzaj { get; set; }

        public int? ZaN_PcKID { get; set; }

        public short? ZaN_KnDTyp { get; set; }

        public int? ZaN_KnDFirma { get; set; }

        public int? ZaN_KnDNumer { get; set; }

        public short? ZaN_KnDLp { get; set; }

        public short? ZaN_FiaskoID { get; set; }

        public int? ZaN_RokMiesiac { get; set; }

        public short? ZaN_PotwOferty { get; set; }

        public int? ZaN_DataPotwOferty { get; set; }

        public short? ZaN_OpeTypPotwOfe { get; set; }

        public int? ZaN_OpeFirmaPotwOfe { get; set; }

        public int? ZaN_OpeNumerPotwOfe { get; set; }

        public short? ZaN_OpeLpPotwOfe { get; set; }

        public int? ZaN_DataAktywacjiRez { get; set; }

        [StringLength(255)]
        public string ZaN_Url { get; set; }

        public decimal? ZaN_RabatW { get; set; }

        public int? ZaN_FrSID { get; set; }

        [StringLength(1)]
        public string ZaN_FlagaNB { get; set; }

        public short? ZaN_OpeTypMod { get; set; }

        public int? ZaN_OpeFirmaMod { get; set; }

        public int? ZaN_OpeNumerMod { get; set; }

        public short? ZaN_OpeLpMod { get; set; }

        public int? ZaN_OddDokId { get; set; }

        public int? ZaN_LastMod { get; set; }

        public short? ZaN_OpiTyp { get; set; }

        public int? ZaN_OpiFirma { get; set; }

        public int? ZaN_OpiNumer { get; set; }

        public short? ZaN_OpiLP { get; set; }

        [StringLength(4)]
        public string ZaN_IncotermsSymbol { get; set; }

        [StringLength(255)]
        public string ZaN_IncotermsMiejsce { get; set; }

        [StringLength(2)]
        public string ZaN_KrajPrzezWys { get; set; }

        [StringLength(2)]
        public string ZaN_KodRodzajuTransportu { get; set; }

        [StringLength(2)]
        public string ZaN_KodRodzajuTransakcji { get; set; }

        public byte? ZaN_Wyslano { get; set; }

        public short? ZaN_CenaSpr { get; set; }

        public int? ZaN_GodzinaWystawienia { get; set; }

        public int? ZaN_GodzinaPotwierdzenia { get; set; }

        public int? ZaN_Promocje { get; set; }

        public byte? ZaN_RezerwujZasoby { get; set; }

        public byte? ZaN_PriorytetRez { get; set; }

        public decimal? ZaN_RabatPromocyjnyGlobalny { get; set; }

        public short? ZaN_KnPTyp { get; set; }

        public int? ZaN_KnPNumer { get; set; }

        public int? ZaN_AdPNumer { get; set; }

        public short? ZaN_MaGDTyp { get; set; }

        public int? ZaN_MagDNumer { get; set; }

        public int? ZaN_KarNumer { get; set; }

        public int? ZaN_PrjId { get; set; }

        public short? ZaN_KnSTypOdb { get; set; }

        public int? ZaN_KnSFirmaOdb { get; set; }

        public int? ZaN_KnSNumerOdb { get; set; }

        public short? ZaN_KnSLpOdb { get; set; }

        public short? ZaN_KnSTypPlt { get; set; }

        public int? ZaN_KnSFirmaPlt { get; set; }

        public int? ZaN_KnSNumerPlt { get; set; }

        public short? ZaN_KnSLpPlt { get; set; }

        public byte? ZaN_RodzajDatyRealizacji { get; set; }

        public int? ZaN_FrMNumer { get; set; }

        public byte? ZaN_PromocjePar { get; set; }

        public byte? ZaN_RezerwacjeNaNiepotwierdzonym { get; set; }

        public short? ZaN_StanZapytania { get; set; }

        public int? ZaN_OpeNumerPotwZapyt { get; set; }

        public byte? ZaN_GenerujWieleZam { get; set; }

        public byte? ZaN_FormatkaCyr { get; set; }

        public int? ZaN_WtrID { get; set; }

        public int? ZaN_WtrProgID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZamElem> ZamElem { get; set; }
    }
}
