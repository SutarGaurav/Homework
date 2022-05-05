using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Assignments.May042022
{
    class Course
    {
        internal byte CId { get; set; }
        internal string CName { get; set; }
        internal ushort CFees { get; set; } 
        internal byte CDur { get; set; }
    }
    class CourseMain
    {
        static void Main (string[] args)
        {
            List<Course> courselist = new List<Course>()
            {
                new Course {CId = 101, CName = "C#", CFees = 10000, CDur = 2},
                new Course {CId = 102, CName = "Java", CFees = 15000, CDur = 3},
                new Course {CId = 103, CName = "JS", CFees = 5000, CDur = 1}
            };
            //1 Expensive to cheap course
            Console.WriteLine("Expensive to cheap course");
            var result1 = from c in courselist
                          orderby c.CFees descending
                          select c;
            foreach(Course c in result1)
            {
                Console.WriteLine($"\t{c.CFees} {c.CId} {c.CName} {c.CDur}");
            }
            /*__________________________________________________________________*/

            //2 Cheap to Expensive course
            Console.WriteLine("Cheap to Expensive course");
            var result2 = from c in courselist
                          orderby c.CFees
                          select c;
            foreach (Course c in result2)
            {
                Console.WriteLine($"\t{c.CFees} {c.CId} {c.CName} {c.CDur}");
            }
            /*__________________________________________________________________*/

            //3 Courses below specific price
            Console.WriteLine("Courses below specific price");
            var result3 = from c in courselist
                          where c.CFees < 6000
                          select c;
            foreach (Course c in result3)
            {
                Console.WriteLine($"\t{c.CFees} {c.CId} {c.CName} {c.CDur}");
            }
            /*__________________________________________________________________*/

            //4 Courses above specific price
            Console.WriteLine("Courses above specific price");
            var result4 = from c in courselist
                          where c.CFees > 6000
                          select c;
            foreach (Course c in result4)
            {
                Console.WriteLine($"\t{c.CFees} {c.CId} {c.CName} {c.CDur}");
            }
            /*__________________________________________________________________*/

            //5 Course with highest to lowest duration
            Console.WriteLine("Course with highest to lowest duration");
            var result5 = from c in courselist
                          orderby c.CDur descending
                          select c;
            foreach (Course c in result5)
            {
                Console.WriteLine($"\t{c.CDur} {c.CId} {c.CName} {c.CFees}");
            }           
        }
    }
}
