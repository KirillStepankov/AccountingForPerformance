using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingForPerformance.Interfaces
{
    public interface IDataView
    {
        object DataSource { get; set; }
        object SelectRow { get; }
    }
}
