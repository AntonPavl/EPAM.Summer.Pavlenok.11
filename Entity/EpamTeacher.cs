using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EpamTeacher
    {
        public int EpamTeacherId { get; set; }
        public string TeacherName { get; set; }
        public virtual List<EpamStudent> Students { get; set; }
    }
}
