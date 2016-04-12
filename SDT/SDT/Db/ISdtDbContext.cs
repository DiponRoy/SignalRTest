using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SDT.Db.Models;

namespace SDT.Db
{
    public interface ISdtDbContext : IDisposable
    {
        IDbSet<DevTest> DevTests { get; set; }

        DbContextConfiguration Configuration { get; }
        int SaveChanges();
    }
}
