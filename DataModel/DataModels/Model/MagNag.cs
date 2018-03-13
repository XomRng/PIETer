namespace DataModels.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CDN.MagNag")]
    public partial class MagNag
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MagNag()
        {
            MagElem = new HashSet<MagElem>();
        }

        public short? MaN_GIDTyp { get; set; }

        public int? MaN_GIDFirma { get; set; }

        [Key]
        public int MaN_GIDNumer { get; set; }

        public short? MaN_GIDLp { get; set; }

        public short? MaN_ZrdTyp { get; set; }

        public int? MaN_ZrdFirma { get; set; }

        public int? MaN_ZrdNumer { get; set; }

        public short? MaN_ZrdLp { get; set; }

        public short? MaN_TrMTyp { get; set; }

        public int? MaN_TrMFirma { get; set; }

        public int? MaN_TrMNumer { get; set; }

        public short? MaN_TrMLp { get; set; }

        public short? MaN_TrNTyp { get; set; }

        public short? MaN_TrNRok { get; set; }

        public byte? MaN_TrNMiesiac { get; set; }

        [StringLength(5)]
        public string MaN_TrNSeria { get; set; }

        public int? MaN_TrNNumer { get; set; }

        public short? MaN_TrNLp { get; set; }

        public short? MaN_KntTyp { get; set; }

        public int? MaN_KntFirma { get; set; }

        public int? MaN_KntNumer { get; set; }

        public short? MaN_KntLp { get; set; }

        public short? MaN_KnATyp { get; set; }

        public int? MaN_KnAFirma { get; set; }

        public int? MaN_KnANumer { get; set; }

        public short? MaN_KnALp { get; set; }

        public short? MaN_OpeTyp { get; set; }

        public int? MaN_OpeFirma { get; set; }

        public int? MaN_OpeNumer { get; set; }

        public short? MaN_OpeLp { get; set; }

        public short? MaN_OpeTypR { get; set; }

        public int? MaN_OpeFirmaR { get; set; }

        public int? MaN_OpeNumerR { get; set; }

        public short? MaN_OpeLpR { get; set; }

        public int? MaN_Data3 { get; set; }

        public short? MaN_Stan { get; set; }

        public short? MaN_LicznikKopii { get; set; }

        public short? MaN_MagDTyp { get; set; }

        public int? MaN_MagDFirma { get; set; }

        public int? MaN_MagDNumer { get; set; }

        public short? MaN_MagDLp { get; set; }

        public int? MaN_FrsID { get; set; }

        public int? MaN_Aktywny { get; set; }

        public byte? MaN_Wsk { get; set; }

        [StringLength(250)]
        public string MaN_CechaOpis { get; set; }

        public short? MaN_OpeTypM { get; set; }

        public int? MaN_OpeFirmaM { get; set; }

        public int? MaN_OpeNumerM { get; set; }

        public short? MaN_OpeLpM { get; set; }

        public short? MaN_ZaNTyp { get; set; }

        public int? MaN_ZaNFirma { get; set; }

        public int? MaN_ZaNNumer { get; set; }

        public short? MaN_ZaNLp { get; set; }

        public byte? MaN_TypZrd { get; set; }

        public int? MaN_RokMiesiac { get; set; }

        public int? MaN_FrmNumer { get; set; }

        public int? MaN_ZewnetrznySys { get; set; }

        public int? MaN_ZewnetrzneId { get; set; }

        public int? MaN_LastMod { get; set; }

        public int? MaN_DataOd { get; set; }

        public int? MaN_DataDo { get; set; }

        public short? MaN_SpeTyp { get; set; }

        public int? MaN_SpeFirma { get; set; }

        public int? MaN_SpeNumer { get; set; }

        public short? MaN_SpeLp { get; set; }

        public int? MaN_TrasaId { get; set; }

        public byte? MaN_Realizacja { get; set; }

        [StringLength(20)]
        public string MaN_SposobDostawy { get; set; }

        public byte? MaN_Priorytet { get; set; }

        public byte? MaN_Status { get; set; }

        public byte? MaN_WMS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MagElem> MagElem { get; set; }
    }
}
