using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SDT.Db;

namespace SDT.Uow
{
    public class SdtUow : ISdtUow
    {
        public ISdtDbContext Db { get; set; }

        public SdtUow(ISdtDbContext db)
        {
            Db = db;
            Db.Configuration.ProxyCreationEnabled = false;
            Db.Configuration.LazyLoadingEnabled = false;
        }
    }
}