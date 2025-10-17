using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_grading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var baseDir = AppContext.BaseDirectory;
            var studentsPath = Path.Combine(baseDir, "Data", "students.txt");
            var coursesPath = Path.Combine(baseDir, "Data", "courses.txt");

            var students = DataLoader.LoadStudents(studentsPath, coursesPath);
            ReportPrinter.Print(students);
        }
    }
}
