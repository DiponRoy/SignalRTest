using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SDT.Db.Configurations;
using SDT.Db.Models;

namespace SDT.Db
{
    public class SdtDbMapContext : SdtDbContext
    {
        static SdtDbMapContext()
        {
            Database.SetInitializer<SdtDbMapContext>(null);
        }

        public SdtDbMapContext()
            : base("DbSdt")
        {
        }
    }
}