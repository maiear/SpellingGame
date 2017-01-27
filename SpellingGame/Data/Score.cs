namespace SpellingGame.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Score")]
    public partial class Score
    {
        public long ScoreId { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Username { get; set; }

        public long Points { get; set; }

        [Required]
        [StringLength(2147483647)]
        public string Date { get; set; }
    }
}
