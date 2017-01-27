namespace SpellingGame.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Database : DbContext
    {
        public Database()
            : base("name=Database")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Rule> Rules { get; set; }
        public virtual DbSet<Score> Scores { get; set; }
        public virtual DbSet<Word> Words { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Words)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rule>()
                .HasMany(e => e.Words)
                .WithMany(e => e.Rules)
                .Map(m => m.ToTable("WordRule").MapLeftKey("RuleId").MapRightKey("WordId"));
        }
    }
}
