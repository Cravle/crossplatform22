using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Container
{
    public class DplxListEnum<T> : IEnumerator<T>
        where T : IComparable
    {
        private DplxList<T> container;
        int position = -1;
        public DplxListEnum(DplxList<T> container)
        {
            this.container = container;
        }

        public bool MoveNext()
        {
            position++;
            return (position < container.Count);
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }



        public T Current
        {
            get
            {
               
                return container[position];
            }
        }

    }
}
