using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StudentSolution.Helpers.Enums;

namespace StudentSolution.Model
{
    public class Student
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public StudentType StudentType { get; set; }
        public DateTime LastUpdate { get; set; }

        public Student(string cvsLine)
        {
            var values = cvsLine.Split(',');
            StudentType = (StudentType)Enum.Parse(typeof(StudentType), values[0], true);
            Name = values[1];
        
    }
}
