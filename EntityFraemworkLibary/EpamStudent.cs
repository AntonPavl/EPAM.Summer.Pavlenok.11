using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFraemworkLibary
{
    public class EpamStudent
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public virtual List<EpamTeacher> Teachers { get; set; }
    }
}
