using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp.Model
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Department(int id,string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            return $"Department Id : {Id}\n" +
                $"Department Name : {Name}\n" +
                $"====================\n";
        }

    }
}
