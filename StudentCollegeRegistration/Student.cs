using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollegeRegistration
{
    public class Student
    {
        CollegeRegistration registrar;
        public Student(CollegeRegistration registrar)
        {
            this.registrar = registrar;
        }

        public int StudentID { get; set; }
        public string Name { get; set; }

        public void Register(int collegeID)
        {
            this.registrar.RegisterForCollege(this.StudentID,collegeID);
        }

        public IEnumerable<College> GetRegisteredColleges()
        {
            return registrar.GetRegisteredColleges(this.StudentID);
        }
    }
}
