using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollegeRegistration
{
    public class College
    {
        CollegeRegistration registrar;
        public College(CollegeRegistration collegeRegd)
        {
            this.registrar = collegeRegd;
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public void Register()
        {
            registrar.RegisterCollege(this);
        }
    }
}
