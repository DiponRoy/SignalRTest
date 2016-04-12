using System.Data.Entity;
using System.Linq;

namespace SDT.Db
{
    internal class CcsDbSeedContextInitializer : CreateDatabaseIfNotExists<SdtDbCreateIfNotExistsContext>
    {
        protected override void Seed(SdtDbCreateIfNotExistsContext dbContext)
        {
        }
    }


    /*Buildclassith seed*/
    public class SdtDbCreateIfNotExistsContext : SdtDbContext
    {
        public SdtDbCreateIfNotExistsContext(): base("DbSdt")
        {
        }

        static SdtDbCreateIfNotExistsContext()
        {
            Database.SetInitializer(new CcsDbSeedContextInitializer());
        }

        public void LoadDb()
        {
            DevTests.ToList();
        }
    }
}
