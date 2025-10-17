using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_grading
{
    public partial class ChamplainStudent : Person, IGrading
    {
        public int YearOfRegister { get; set; }
        public double ZScore { get; set; }
        public List<Course> Courses { get; } = new List<Course>();

        public double AverageScore()
        {
            if (Courses.Count == 0) return 0;
            return Courses.Average(c => c.Score);
        }
    }
}
