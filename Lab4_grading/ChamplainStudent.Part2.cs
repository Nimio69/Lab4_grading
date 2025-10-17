using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_grading
{
    public partial class ChamplainStudent
    {
        public double GPA()
        {
            var avg = AverageScore();
            return Math.Round(4.3 * (avg / 100.0), 2);
        }

       
        public double RScore()
        {
            double avgIrg = Courses.Count == 0 ? 0 : Courses.Average(c => c.IRG);
            return Math.Round(5 * ZScore + avgIrg + 35, 2);
        }
    }
}
