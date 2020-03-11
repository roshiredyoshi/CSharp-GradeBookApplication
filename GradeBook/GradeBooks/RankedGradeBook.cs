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

            if (grades[threshold-1] < averageGrade)
            {
                return 'A';
            }
            else if (grades[(threshold*2) - 1] < averageGrade)
            {
                return 'B';
            }
            else if (grades[(threshold*3) - 1] < averageGrade)
            {
                return 'C';
            }
            else if (grades[(threshold*4)-1] < averageGrade)
            {
                return 'D';
            }
            return 'F';
        }

    }
}
