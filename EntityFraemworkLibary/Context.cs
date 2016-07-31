using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFraemworkLibary
{
    public class Context : DbContext
    {
        public Context() : base()
        {

        }

        public DbSet<EpamStudent> Students { get; set; }
        public DbSet<EpamTeacher> Standards { get; set; }

    }
}
