using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public double TwentyPercent = 0;
        // public List<double> Grades;
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }
        
        public override char GetLetterGrade(double averageGrade)
        {
            // Return char letter grade
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work.");
            }
            int threshold = (int)Math.Ceiling(Students.Count * 0.2);
            var grades = Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();
            var count = 0;

            if (count < threshold)
            {
                return 'A';
            }
            else if (count < (threshold * 2))
            {
                return 'B';
            }
            else if (count < (threshold * 3))
            {
                return 'C';
            }
            else if (count < (threshold * 4))
            {
                return 'D';
            }
            return 'F';
        }

    }
}
