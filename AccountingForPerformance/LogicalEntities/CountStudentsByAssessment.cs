using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingForPerformance.LogicalEntities
{
    /// <summary>
    /// Количество учеников на оценку
    /// </summary>
    public class CountStudentsByAssessment
    {

        public CountStudentsByAssessment(int countStudents, int assessment)
        {
            CountStudents = countStudents;
            Assessment = assessment;
        }

        /// <summary>
        /// Количество учеников
        /// </summary>
        public int CountStudents { get; private set; }
        /// <summary>
        /// Оценка
        /// </summary>
        public int Assessment { get; private set; }
    }
}
