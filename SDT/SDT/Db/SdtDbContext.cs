using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SDT.Db.Configurations;
using SDT.Db.Models;

namespace SDT.Db
{
    public abstract class SdtDbContext : DbContext, ISdtDbContext
    {
        protected SdtDbContext (string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new DebTestConfig());
        }

        public IDbSet<DevTest> DevTests { get; set; }
    }
}