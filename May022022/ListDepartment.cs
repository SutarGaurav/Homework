using System;
using System.Collections.Generic;
using System.Text;
//Collections List
namespace CSHomework.May022022
{
    class Department
    {
        internal int EmpCount { get; set; }
        internal string DepName { get; set; }
    }
    class DepMain
    {
        static void Main(string[] args)
        {
            List<Department> deplist = new List<Department>()
            {
                new Department { EmpCount = 15, DepName = "Human Resource"},
                new Department { EmpCount = 20, DepName = "Engineering"},
                new Department { EmpCount = 2500, DepName = "Production"},
                new Department { EmpCount = 50, DepName = "Finance"},
                new Department { EmpCount = 50, DepName = "Quality"},
                new Department { EmpCount = 100, DepName = "Sales"},
                new Department { EmpCount = 50, DepName = "Marketing"},
                new Department { EmpCount = 25, DepName = "Purchase"}
            };
            foreach(Department d in deplist)
            {
                Console.WriteLine($"{d.DepName} \t{d.EmpCount}");
            }
        }
    }
}
