using System;
using System.ComponentModel;

namespace AccountingForPerformance.Entities
{
    [Serializable]
    public class SchoolClass
    {
        [DisplayName("Код")]
        public int Id { get; set; }

        [DisplayName("Класс")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
