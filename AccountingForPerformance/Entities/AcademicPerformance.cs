
using System;

namespace AccountingForPerformance.Entities
{
    [Serializable]
    public class AcademicPerformance
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
