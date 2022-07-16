using System;
using System.ComponentModel;

namespace AccountingForPerformance.Entities
{
    [Serializable]
    public class EducationalInstitution
    {
        [DisplayName("Код")]
        public int Id { get; set; }

        [DisplayName("Учебное заведение")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
