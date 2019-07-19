using System;
using System.Collections.Generic;
using System.Text;

namespace Nivantis.Models.Pharmacy
{
    public class TrainingCourse
    {
        public string Title { get; set; }
        public string Duration { get; set; }
        public string EmployeName { get; set; }
        public string EmployeFirstName { get; set; }
        public int EmployeAge { get; set; }
        public DateTime AskedDate { get; set; }

        public TrainingCourse(string title, string duration, string employeName, string employeFirstName, int employeAge, DateTime askedDate)
        {
            Title = title;
            Duration = duration;
            EmployeName = employeName;
            EmployeFirstName = employeFirstName;
            EmployeAge = employeAge;
            AskedDate = askedDate;
        }
    }
}
