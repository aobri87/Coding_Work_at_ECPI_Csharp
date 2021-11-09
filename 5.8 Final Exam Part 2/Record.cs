// Name: Andrew O'Brien
// Date: 19 July 2021
// Record.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._8_Final_Exam_Part_2
{
    class Record
    {
        public int Rating { get; set; }

        // parameterless constructor sets members to default values
        public Record() : this(0) { }

        // overloaded constructor sets members to parameter values
        public Record(int rating)
        {
            Rating = rating;
        }
    }
}
