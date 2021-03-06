﻿using StudentSolution.Helpers;
using System;
using static StudentSolution.Helpers.Enums;

namespace StudentSolution.Model
{
    public class Student
    {
        public string Name { get; private set; }
        public Gender Gender { get; private set; }
        public StudentType StudentType { get; private set; }
        public DateTime LastUpdate { get; private set; }

        public Student(string cvsLine)
        {
            var values = cvsLine.Split(',');
            StudentType = (StudentType)Enum.Parse(typeof(StudentType), values[0], true);
            Name = values[1];
            LastUpdate = ConvertHelpers.ConvertToDate(values[3]);
            Gender = ConvertHelpers.ConvertToGender(values[2]);
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}",StudentType.ToString(), Name, ConvertHelpers.ConvertEnumGenderToChar(Gender), LastUpdate.ToString("yyyyMMddHHmmss"));
        }
        public Student(string name, string gender, string studentType)
        {
            Name = name;
            StudentType = (StudentType)Enum.Parse(typeof(StudentType), studentType, true);
            Gender = ConvertHelpers.ConvertToGender(gender);
            LastUpdate = DateTime.Now;
        }
    }
}
