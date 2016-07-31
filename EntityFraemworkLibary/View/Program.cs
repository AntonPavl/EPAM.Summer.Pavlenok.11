using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFraemworkLibary;
using System.Data.Entity;

namespace View
{
    public class Context : DbContext
    {
        public Context() : base()
        {

        }

        public DbSet<EpamStudent> Students { get; set; }
        public DbSet<EpamTeacher> Standards { get; set; }

    }

    public class EpamStudent
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public virtual List<EpamTeacher> Teachers { get; set; }
    }

    public class EpamTeacher
    {
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public virtual List<EpamStudent> Students { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context())
            {

            }
        }
    }
}
