using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCollegeRegistration
{
    public class CollegeRegistration
    {
        Dictionary<int, List<int>> registrations = new Dictionary<int, List<int>>();
        List<College> colleges = new List<College>();

        private void AddColleges(College college)
        {
            colleges.Add(college);
        }

        public void RegisterForCollege(int studentID, int collegeID)
        {
            if (!registrations.ContainsKey(studentID))
            {
                registrations.Add(studentID, new List<int>());
            }
            registrations[studentID].Add(collegeID);
        }

        internal void RegisterCollege(College college)
        {
            AddColleges(college);
        }

        public IEnumerable<College> GetRegisteredColleges(int studentID)
        {
            if (registrations.ContainsKey(studentID))
            {
                var match = from regd in registrations[studentID]
                            join college in colleges
                            on regd equals college.ID
                            select college;
                return match;
            }
            return new List<College>();
        }
    }
}
