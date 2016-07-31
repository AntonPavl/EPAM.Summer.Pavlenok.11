using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Entity
{

    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context())
            {
                EpamStudent ES = new EpamStudent();
                ES.StudentName = "Student1";
                EpamTeacher ET = new EpamTeacher();
                ET.TeacherName = "Teacher1";
                ES.Teachers.Add(ET);

                db.Students.Add(ES);
                db.SaveChanges();
            }
        }
    }
}
