using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_grading
{
    public class Course
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public int Score { get; set; }
        public string GroupId { get; set; }
        public int IRG { get; set; }

        public Course(string courseId, string courseName, int score, string groupId, int irg)
        {
            CourseId = courseId;
            CourseName = courseName;
            Score = score;
            GroupId = groupId;
            IRG = irg;
        }
    }
}
