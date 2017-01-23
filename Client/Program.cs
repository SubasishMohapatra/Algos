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
            var registar = new CollegeRegistration();

            new College(registar) { ID = 1, Name = "Stewart" }.Register();
            new College(registar) { ID = 2, Name = "Christ" }.Register();
            new College(registar) { ID = 3, Name = "Utkal" }.Register();
            new College(registar) { ID = 4, Name = "JKBK" }.Register();
            new College(registar) { ID = 5, Name = "Ravenshaw" }.Register();
            new College(registar) { ID = 6, Name = "City" }.Register();

            var student1 = new Student(registar) { Name = "Subasish", StudentID = 1 };
            student1.Register(1);
            student1.Register(5);
            student1.Register(6);
            var student2 = new Student(registar) { Name = "Debasish", StudentID = 2 };
            student2.Register(2);
            student2.Register(4);
            var student3 = new Student(registar) { Name = "Sameer", StudentID = 3 };
            student3.Register(3);
            student3.Register(5);
            var student4 = new Student(registar) { Name = "Neha", StudentID = 4 };
            student4.Register(4);
            student4.Register(5);
            var student5 = new Student(registar) { Name = "Roopa", StudentID = 5 };
            student5.Register(5);
            student5.Register(6);
            var student6 = new Student(registar) { Name = "Sam", StudentID = 6 };
            student6.Register(6);
            student6.Register(1);
            var student7 = new Student(registar) { Name = "Harry", StudentID = 7 };
            student7.Register(1);
            student7.Register(2);
            var student8 = new Student(registar) { Name = "Akbar", StudentID = 8 };
            student8.Register(2);
            student8.Register(3);
            student8.Register(4);
            var student9 = new Student(registar) { Name = "Romeo", StudentID = 9 };
            student9.Register(5);
            student9.Register(6);
            student9.Register(1);
            var student10 = new Student(registar) { Name = "Duggu", StudentID = 10 };
            student10.Register(2);
            student10.Register(3);
            student10.Register(4);


            Console.WriteLine($"{student3.Name} has registered for below colleges:");
            foreach (var college in student3.GetRegisteredColleges())
            {
                Console.WriteLine($"{college.Name}");
            }

            Console.ReadLine();
        }
    }
}
