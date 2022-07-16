using System;
using System.ComponentModel;

namespace AccountingForPerformance.Entities
{
    [Serializable]
    public class SchoolSubject
    {
        [DisplayName("Код")]
        public int Id { get; set; }
        
        [DisplayName("Школьный предмет")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
