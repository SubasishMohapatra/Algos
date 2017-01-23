using StudentCollegeRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var registar=new CollegeRegistration();

            registar.AddColleges(new College() { ID = 1, Name = "Stewart" });
            registar.AddColleges(new College() { ID = 2, Name = "Christ" });
            registar.AddColleges(new College() { ID = 3, Name = "Utkal" });
            registar.AddColleges(new College() { ID = 4, Name = "JKBK" });
            registar.AddColleges(new College() { ID = 5, Name = "Ravenshaw" });
            registar.AddColleges(new College() { ID = 6, Name = "City" });

            new Student() { Name = "Subasish", StudentID = 1 };
            new Student() { Name = "Subasish", StudentID = 2 };
            new Student() { Name = "Subasish", StudentID = 3 };
            new Student() { Name = "Subasish", StudentID = 4 };
            new Student() { Name = "Subasish", StudentID = 5 };
            new Student() { Name = "Subasish", StudentID = 6 };
            new Student() { Name = "Subasish", StudentID = 7 };
            new Student() { Name = "Subasish", StudentID = 8 };
            new Student() { Name = "Subasish", StudentID = 9 };
            new Student() { Name = "Subasish", StudentID = 10 };

            registar.Register(1, 5);registar.Register(1, 1);registar.Register(1, 6);
            registar.Register(2, 2);registar.Register(2, 4);
            registar.Register(3, 3); registar.Register(3, 5);
            registar.Register(4, 4); registar.Register(4, 6);
            registar.Register(5, 5); registar.Register(5, 7);
            registar.Register(6, 6);
            registar.Register(7, 7); registar.Register(7, 8);
            registar.Register(8, 8);
            registar.Register(9, 9);
            registar.Register(10, 5); registar.Register(10, 10);

            foreach(var college in registar.GetRegisteredColleges(1))
            {
                Console.WriteLine($"{college.Name}");
            }

            Console.ReadLine();
        }
    }
}
