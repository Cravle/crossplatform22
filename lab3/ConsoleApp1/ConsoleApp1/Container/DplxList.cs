using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Container
{
    public class DplxList<T>
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

    }
}
