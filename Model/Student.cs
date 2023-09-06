using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp.Model
{
    internal class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        
        public Student(int rollNo ,string name)
        {
            RollNo = rollNo;
            Name = name;
        }
        public override string ToString()
        {
            return $"Student Roll No : {RollNo}\n" +
                $"Student Name : {Name}\n" +
                $"==============================\n";
        }
    }
}
