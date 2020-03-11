using System;
using System.Collections.Generic;
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
            if (Students.Count <= 5)
            {
                throw InvalidOperationException("Ranked-grading requires a minimum of 5 students to work.");
            }
            // TwentyPercent = (Students.Count * .2);
            
            return 'F';
            
            //else if (true)
            //{
            //    return 'B';
            //}
            //else if (true)
            //{
            //    return 'C';
            //}
            //else if (true)
            //{
            //    return 'D';
            //}
            //return 'F';
        }

        private Exception InvalidOperationException(string v)
        {
            throw new NotImplementedException();
        }
    }
}
