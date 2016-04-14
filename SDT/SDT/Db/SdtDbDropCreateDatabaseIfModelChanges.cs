using System.Data.Entity;
using System.Linq;

namespace SDT.Db
{
    internal class CcsDbSeedContextInitializer : DropCreateDatabaseIfModelChanges<SdtDbDropCreateDatabaseIfModelChanges>
    {
        protected override void Seed(SdtDbDropCreateDatabaseIfModelChanges dbDropContext)
        {
        }
    }

    public class SdtDbDropCreateDatabaseIfModelChanges : SdtDbContext
    {
        public SdtDbDropCreateDatabaseIfModelChanges(): base("DbSdt")
        {
        }

        static SdtDbDropCreateDatabaseIfModelChanges()
        {
            Database.SetInitializer(new CcsDbSeedContextInitializer());
        }

        public void LoadDb()
        {
            DevTests.ToList();
        }
    }
}
