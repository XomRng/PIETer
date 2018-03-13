namespace DataModels.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CDN.KntAdresy")]
    public partial class KntAdresy
    {
        public short? KnA_GIDTyp { get; set; }

        public int? KnA_GIDFirma { get; set; }

        [Key]
        public int KnA_GIDNumer { get; set; }

        public short? KnA_GIDLp { get; set; }

        public short? KnA_KntTyp { get; set; }

        public int? KnA_KntFirma { get; set; }

        public int? KnA_KntNumer { get; set; }

        public short? KnA_KntLp { get; set; }

        public int? KnA_DataArc { get; set; }

        [StringLength(20)]
        public string KnA_Akronim { get; set; }

        public byte? KnA_Wysylkowy { get; set; }

        [StringLength(50)]
        public string KnA_Nazwa1 { get; set; }

        [StringLength(50)]
        public string KnA_Nazwa2 { get; set; }

        [StringLength(250)]
        public string KnA_Nazwa3 { get; set; }

        [StringLength(10)]
        public string KnA_KodP { get; set; }

        [StringLength(30)]
        public string KnA_Miasto { get; set; }

        [StringLength(30)]
        public string KnA_Ulica { get; set; }

        [StringLength(30)]
        public string KnA_Adres { get; set; }

        [StringLength(13)]
        public string KnA_NipE { get; set; }

        [StringLength(13)]
        public string KnA_Nip { get; set; }

        [StringLength(2)]
        public string KnA_NipPrefiks { get; set; }

        [StringLength(20)]
        public string KnA_Regon { get; set; }

        [StringLength(11)]
        public string KnA_Pesel { get; set; }

        [StringLength(30)]
        public string KnA_KontoDostawcy { get; set; }

        [StringLength(30)]
        public string KnA_KontoOdbiorcy { get; set; }

        [StringLength(2)]
        public string KnA_Kraj { get; set; }

        [StringLength(30)]
        public string KnA_Powiat { get; set; }

        [StringLength(30)]
        public string KnA_Gmina { get; set; }

        [StringLength(30)]
        public string KnA_Wojewodztwo { get; set; }

        public int? KnA_RegionCRM { get; set; }

        [StringLength(13)]
        public string KnA_GLN { get; set; }

        [StringLength(30)]
        public string KnA_Telefon1 { get; set; }

        [StringLength(30)]
        public string KnA_Telefon2 { get; set; }

        [StringLength(30)]
        public string KnA_Fax { get; set; }

        [StringLength(30)]
        public string KnA_Modem { get; set; }

        [StringLength(30)]
        public string KnA_Telex { get; set; }

        [StringLength(255)]
        public string KnA_EMail { get; set; }

        public short? KnA_BnkTyp { get; set; }

        public int? KnA_BnkFirma { get; set; }

        public int? KnA_BnkNumer { get; set; }

        public short? KnA_BnkLp { get; set; }

        [StringLength(50)]
        public string KnA_NrRachunku { get; set; }

        public int? KnA_LastModL { get; set; }

        public decimal? KnA_Odleglosc { get; set; }

        public short? KnA_NRB { get; set; }

        public short? KnA_NiePublikuj { get; set; }

        public short? KnA_Domyslny { get; set; }

        [StringLength(50)]
        public string KnA_DokumentTozsamosci { get; set; }

        public int? KnA_DataWydania { get; set; }

        [StringLength(50)]
        public string KnA_OrganWydajacy { get; set; }

        public byte? KnA_RolnikRyczaltowy { get; set; }

        public byte? KnA_StanPostep { get; set; }

        public byte? KnA_PlatnikVat { get; set; }

        public decimal? KnA_GPSSz { get; set; }

        public decimal? KnA_GPSDl { get; set; }

        public int? KnA_GPSDataPobrania { get; set; }

        public int? KnA_GPSGodzinaPobrania { get; set; }
    }
}
