namespace SpellingGame.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rule")]
    public partial class Rule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rule()
        {
            Words = new HashSet<Word>();
        }

        public long RuleId { get; set; }

        [StringLength(2147483647)]
        public string RuleName { get; set; }

        [StringLength(2147483647)]
        public string RuleDescription { get; set; }

        [StringLength(2147483647)]
        public string RuleShortVersion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Word> Words { get; set; }
    }
}
