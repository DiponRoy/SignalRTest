using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDT.Db;

namespace SDT.Uow
{
    public interface ISdtUow
    {
        ISdtDbContext Db { get; set; }
    }
}
