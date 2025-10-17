using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_grading
{
    public static class ReportPrinter
    {
        public static void Print(IEnumerable<ChamplainStudent> students)
        {
            Console.WriteLine("Champlain College — Lab 4 Grading Report");
            Console.WriteLine(new string('=', 60));
            foreach (var s in students.OrderBy(s => s.Id))
            {
                Console.WriteLine(
                    $"ID: {s.Id} | {s.Name} | Age {s.Age} | DoB {s.DateOfBirth:yyyy-MM-dd} | Gender {s.Gender} | YR {s.YearOfRegister}"
                );
                Console.WriteLine("Courses:");
                foreach (var c in s.Courses)
                {
                    Console.WriteLine($"  - {c.CourseId} {c.CourseName} | Score {c.Score} | Group {c.GroupId} | IRG {c.IRG}");
                }
                Console.WriteLine($"Average: {s.AverageScore():0.00} | GPA: {s.GPA():0.00} | R-Score: {s.RScore():0.00}");
                Console.WriteLine(new string('-', 60));
            }
        }
    }
}

