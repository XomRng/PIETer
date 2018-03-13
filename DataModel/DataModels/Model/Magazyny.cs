namespace DataModels.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CDN.Magazyny")]
    public partial class Magazyny
    {
        public short? MAG_GIDTyp { get; set; }

        public int? MAG_GIDFirma { get; set; }

        [Key]
        public int MAG_GIDNumer { get; set; }

        public short? MAG_GIDLp { get; set; }

        [StringLength(10)]
        public string MAG_Kod { get; set; }

        [StringLength(30)]
        public string MAG_Nazwa { get; set; }

        [StringLength(10)]
        public string MAG_KodP { get; set; }

        [StringLength(30)]
        public string MAG_Miasto { get; set; }

        [StringLength(30)]
        public string MAG_Ulica { get; set; }

        [StringLength(30)]
        public string MAG_Adres { get; set; }

        public short? MAG_PrcTyp { get; set; }

        public int? MAG_PrcFirma { get; set; }

        public int? MAG_PrcNumer { get; set; }

        public short? MAG_PrcLp { get; set; }

        public decimal? MAG_Pojemnosc { get; set; }

        [StringLength(30)]
        public string MAG_Konto { get; set; }

        [StringLength(200)]
        public string MAG_Opis { get; set; }

        public byte? MAG_Wewnetrzny { get; set; }

        public byte? MAG_Pico { get; set; }

        public byte? MAG_Zarzadzanie { get; set; }

        public short? MAG_KntTyp { get; set; }

        public int? MAG_KntFirma { get; set; }

        public int? MAG_KntNumer { get; set; }

        public short? MAG_KntLp { get; set; }

        public byte? MAG_Zablokowany { get; set; }

        public int? MAG_DataInw { get; set; }

        [StringLength(30)]
        public string MAG_KontoInw { get; set; }

        [StringLength(2)]
        public string MAG_Kraj { get; set; }

        public int? MAG_CzasModyfikacji { get; set; }

        public int? MAG_OpeMNumer { get; set; }

        public decimal? MAG_AnalizaA { get; set; }

        public decimal? MAG_AnalizaB { get; set; }

        public decimal? MAG_AnalizaX { get; set; }

        public decimal? MAG_AnalizaY { get; set; }

        public byte? MAG_AnalizaABCXYZ { get; set; }

        public byte? MAG_WMS { get; set; }
    }
}
