using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SDT.Db.Models;

namespace SDT.Db.Configurations
{
    public class DebTestConfig : EntityTypeConfiguration<DevTest>
    {
        public DebTestConfig()
        {
            HasKey(x => x.Id);
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CampaingnName)
                .IsOptional()
                .HasColumnType("VARCHAR")
                .HasMaxLength(255);

            Property(x => x.Date)
                .IsOptional()
                .HasColumnType("DATE");

            Property(x => x.Clicks)
                .IsOptional();

            Property(x => x.Conversions)
                .IsOptional();

            Property(x => x.Impressions)
                .IsOptional();

            Property(x => x.AffiliateName)
                .IsOptional()
                .HasColumnType("VARCHAR")
                .HasMaxLength(255);
        }
    }
}