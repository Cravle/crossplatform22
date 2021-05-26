using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Container
{
    public class DplxList<T> : IEnumerable
        where T : IComparable
    {
        public DplxItem<T> Head { get; set; }
        public DplxItem<T> Tail { get; set; }
        public int Count { get; set; }

        public DplxList() { }

        public DplxList(T data)
        {
            var item = new DplxItem<T>(data);
            Head = item;
            Tail = item;
            Count = 1;

        }

        public void Add(T data)
        {
            var item = new DplxItem<T>(data);

            if (Count == 0)
            {
                Head = item;
                Tail = item;
                Count = 1;
                return;
            }

            Tail.Next = item;
            item.Previous = Tail;
            Tail = item;
            Count++;
        }

        public void DeleteByID(int id)
        {
            var current = Head;
            int i = 0;
            while (current != null)
            {

                if (id == 0)
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }
                if (id == Count - 1)
                {
                    Tail.Previous.Next = null;
                    Count--;
                    return;
                }


                if (i == id)
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    Count--;
                    return;
                }


                current = current.Next;
                i++;
            }
        }

        public void Print()
        {

            var current = Head;
            while (current != null)
            {
                Console.WriteLine(current + " ");
                current = current.Next;
            }
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new DplxListEnum<T>(this);
        }

        public T this[int i]
        {
            
            get
            {
                
                    DplxItem<T> current = Head;
                    int counter = 0;
                    while (current != null)
                    {
                        if (counter == i)
                            return current.Data;
                        current = current.Next;
                        counter++;
                    }
                return current.Data;
                
            }
        }

    }
}
