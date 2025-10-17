using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_grading
{
    internal interface IGrading
    {
        double AverageScore();
        double GPA();
        double RScore();
    }
}
