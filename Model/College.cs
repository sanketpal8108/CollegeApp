using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp.Model
{
    internal class College
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        List<Student> Students;
        List<Department> Departments;
        List<Professor> Professors;
        public College(int id, string name, string city)
        {
            Id = id;
            Name = name;
            City = city;
            Students = new List<Student>
            {
                new Student(1,"Sanket"),
                new Student(2,"Shreyash")
            };
            Departments = new List<Department>
            {
                new Department(101,"CS"),
                new Department(102,"IT")
            };
            Professors = new List<Professor>
            {
                new Professor(201,"Yash","JS"),
                
                new Professor(202,"Samruddhi" , "C#")
            };
        }
        private string GetStudent()
        {
            string data = "";
            foreach (Student student in Students)
            {
                data += student;
            }
            return data;
        }
        private string GetDepartment()
        {
            string data = "";
            foreach(Department department in Departments)
            {
                data += department;
            }
            return data;
        }
        private string GetProfessor()
        {
            string data = "";
            foreach(Professor professor in Professors)
            { data += professor.ToString();}
            return data;
        }
        public override string ToString()
        {
            string student = GetStudent();
            string department = GetDepartment();
            string professor = GetProfessor();
            return $"College ID: {Id} , Name : {Name} , City : {City}\n" +
                $"-------Professors-----------\n" +
                $"{professor}\n" +
                $"------------Students----------\n" +
                $"{student}\n" +
                $"-------Departments----------\n" +
                $"{department}\n";
        }
    }
}
