namespace DataModels.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CDN.AtrybutyKlasy")]
    public partial class AtrybutyKlasy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AtrybutyKlasy()
        {
            Atrybuty = new HashSet<Atrybuty>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AtK_ID { get; set; }

        public short AtK_Typ { get; set; }

        [Required]
        [StringLength(255)]
        public string AtK_Nazwa { get; set; }

        [StringLength(255)]
        public string AtK_Opis { get; set; }

        [StringLength(128)]
        public string AtK_Format { get; set; }

        public byte? AtK_ZListy { get; set; }

        public byte? AtK_Zamknieta { get; set; }

        public byte? AtK_Wymagany { get; set; }

        public byte? AtK_Controlling { get; set; }

        public byte? AtK_Automat { get; set; }

        public byte? AtK_Nieaktywny { get; set; }

        [StringLength(2048)]
        public string AtK_SQL { get; set; }

        public byte? AtK_Historia { get; set; }

        [StringLength(255)]
        public string AtK_Domyslna { get; set; }

        [StringLength(255)]
        public string AtK_DomyslnaAPI { get; set; }

        public short? AtK_DomTyp { get; set; }

        public int? AtK_DomFirma { get; set; }

        public int? AtK_DomNumer { get; set; }

        public short? AtK_DomLp { get; set; }

        public short? AtK_DomAPITyp { get; set; }

        public int? AtK_DomApiFirma { get; set; }

        public int? AtK_DomAPINumer { get; set; }

        public short? AtK_DomAPILp { get; set; }

        [StringLength(2048)]
        public string AtK_DomyslnaSQL { get; set; }

        [StringLength(2048)]
        public string AtK_DomyslnaAPISQL { get; set; }

        public byte? AtK_TypDom { get; set; }

        public byte? AtK_TypDomApi { get; set; }

        public int? AtK_CharSet { get; set; }

        public int? AtK_OptimaId { get; set; }

        public byte? AtK_Okresowe { get; set; }

        public byte? AtK_Wielowart { get; set; }

        public byte? AtK_ReadOnly { get; set; }

        public byte? AtK_iZam { get; set; }

        public byte? AtK_eSklep { get; set; }

        public int? AtK_CzasModyfikacji { get; set; }

        public byte? AtK_MOBMPrawa { get; set; }

        public byte? AtK_MOBSPrawa { get; set; }

        public byte? AtK_PRACPrawa { get; set; }

        public int? AtK_OddZrdID { get; set; }

        public byte? AtK_iMall { get; set; }

        public byte? AtK_Synchronizowany { get; set; }

        public byte? AtK_WMS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Atrybuty> Atrybuty { get; set; }
    }
}
