using AccountingForPerformance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingForPerformance.Interfaces
{
    public interface ISerialize
    {
        void Serializable(List<SchoolPerformance> performances);

        List<SchoolPerformance> Deserializable(string pathToFile);
    }
}
