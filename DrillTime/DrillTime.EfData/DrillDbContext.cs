using DrillTime.DomainClasses;

namespace DrillTime.EfData
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    //set up a default configuration so that you don't have to include EF in every single project.
    [DbConfigurationType(typeof(SqlDefaultDbConfiguration))]
    public partial class DrillDbContext : DbContext
    {
        public DrillDbContext()
            : base("name=DrillDbContext")
        {
        }

        public virtual DbSet<Drill> Drills { get; set; }
        public virtual DbSet<LogEntry> LogEntries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //below is kept here for reference if we need to add something like this.

            //modelBuilder.Entity<LogEntry>()
            //    .HasMany(e => e.LogEntry1)
            //    .WithOptional(e => e.LogEntry2)
            //    .HasForeignKey(e => e.PreviousLogIdForDrill);
        }
    }
}
