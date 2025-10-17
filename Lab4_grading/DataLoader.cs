using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_grading
{
    public static class DataLoader
    {
        public static List<ChamplainStudent> LoadStudents(string studentsPath, string coursesPath)
        {
            var students = new Dictionary<int, ChamplainStudent>();

            foreach (var line in File.ReadLines(studentsPath).Skip(1))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var parts = line.Split(',');
                var id = int.Parse(parts[0]);
                var name = parts[1];
                var age = int.Parse(parts[2]);
                var dob = DateTime.Parse(parts[3], CultureInfo.InvariantCulture);
                var gender = parts[4][0];
                var year = int.Parse(parts[5]);
                var z = double.Parse(parts[6], CultureInfo.InvariantCulture);

                students[id] = new ChamplainStudent
                {
                    Id = id,
                    Name = name,
                    Age = age,
                    DateOfBirth = dob,
                    Gender = gender,
                    YearOfRegister = year,
                    ZScore = z
                };
            }

            foreach (var line in File.ReadLines(coursesPath).Skip(1))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var parts = line.Split(',');
                var sid = int.Parse(parts[0]);
                var courseId = parts[1];
                var courseName = parts[2];
                var score = int.Parse(parts[3]);
                var groupId = parts[4];
                var irg = int.Parse(parts[5]);

                ChamplainStudent stu;
                if (students.TryGetValue(sid, out stu))
                {
                    stu.Courses.Add(new Course(courseId, courseName, score, groupId, irg));
                }
            }

            return students.Values.ToList();
        }
    }
}

