using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp.Model
{
    internal class Professor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public Professor(int id, string name, string subject)
        {
            Id = id;
            Name = name;
            Subject = subject;
        }
        public override string ToString()
        {
            return $"Professor Id : {Id}\n" +
                $"Professor Name : {Name}\n" +
                $"Subject : {Subject}\n" +
                $"=======================\n";
        }
    }
}
