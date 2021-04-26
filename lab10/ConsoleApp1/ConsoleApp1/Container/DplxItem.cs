using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Container
{
    public class DplxItem<T>
    {
        public T Data { get; set; }
        public DplxItem<T> Next { get; set; }
        public DplxItem<T> Previous { get; set; }

        public DplxItem(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
