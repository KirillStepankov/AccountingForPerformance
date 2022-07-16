using AccountingForPerformance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingForPerformance.Data
{
    public class SingletonDataContext
    {
        private static SingletonDataContext instance;
        public IDataContext DataContext { get; private set; }   // N_N - readonly недоступен
        private SingletonDataContext()
        {
            DataContext = new DataContext();
        }

        public static SingletonDataContext GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new SingletonDataContext();
                
                return instance;
            }
        }
    }
}
