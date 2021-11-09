using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Record
    {
        public string Last { get; set; }
        public string First { get; set; }
        public int ID { get; set; }
        public string Course { get; set; }
        public string Grade { get; set; }

        // parameterless constructor sets members to default values
        public Record() : this(string.Empty, string.Empty, 0, string.Empty, string.Empty) { }

        // overloaded constructor sets members to parameter values
        public Record(string lastName, string firstName, int id, string course, string grade)
        {
            Last = lastName;
            First = firstName;
            ID = id;
            Course = course;
            Grade = grade;
        }
    }
}
