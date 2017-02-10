namespace SpellingGame.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Word")]
    public partial class Word
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Word()
        {
            Rules = new HashSet<Rule>();
        }

        public long WordId { get; set; }

        [Column("Word")]
        [Required]
        [StringLength(2147483647)]
        public string Word1 { get; set; }

        public long CategoryId { get; set; }

        [MaxLength(2147483647)]
        public byte[] Image { get; set; }

        [StringLength(2147483647)]
        public string Sentence { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rule> Rules { get; set; }
    }
}
