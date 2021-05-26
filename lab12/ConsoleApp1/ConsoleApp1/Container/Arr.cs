using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Container
{
    public class Arr<T> : IEnumerable
        where T : IComparable
    {

        public delegate int delegCompareForSort(T a, T b);
        public delegate int delegCompareForFind(T a, string b);
        public delegate int delegCompareForFindAll(T a, int b);

        private T[] Container;
        public int Count { get; set; }
        private int Size = 5;
        public Arr()
        {
            Count = 0;
            Container = new T[Size];
        }

        public void Add(T P)
        {
            if (Count < Size)
            {
                Container[Count] = P;
                Count++;
            }
            else
            {
                T[] temp = new T[++Count];
                for (int i = 0; i < Count - 1; i++)
                {
                    temp[i] = Container[i];
                }

                temp[Count - 1] = P;
                Container = temp;
            }

        }

        public void Delete(int index)
        {
            T[] temp = new T[--Count];
            int i = 0;
            int j = 0;
            while (i <= Count)
            {
                if (i != index)
                {
                    temp[j] = Container[i];
                    j++;
                }
                i++;
            }
            Container = temp;
        }

        public void Sort(delegCompareForSort compare)
        {
            T temp;
            for (int i = 0; i < Count; i++)
            {

                for (int j = 0; j < Count - 1; j++)
                {
                    if (compare(Container[i],Container[j]) == -1)
                    {
                        temp = Container[i];
                        Container[i] = Container[j];
                        Container[j] = temp;
                    }
                }
            }
        }

        public void Find(delegCompareForFind compare, string naz)
        {
            for (int i = 0; i< Count; i++)
            {
                if(compare(Container[i], naz) == 0)
                {
                    Console.WriteLine(Container[i]);
                    return;
                }
            }
        }

        public void FindAll(delegCompareForFindAll compare, int price)
        {
            for (int i = 0; i < Count; i++)
            {
                if (compare(Container[i], price) == 0)
                {
                    Console.WriteLine(Container[i]);
                }
            }
        }

        public T this[int i]
        {
            set { Container[i] = value; }
            get
            {
                if (i >= Count || i < 0)
                {
                    ArrEx e = new ArrEx();
                    e.Data.Add("Index", i);
                    throw e;
                }
                return Container[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator ()
        {
            return (IEnumerator)GetEnumerator();
        }

        public IEnumerator<T>GetEnumerator()
        {
            return new ArrEnum<T>(this);
        }

        public IEnumerable<T> InverseEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
                yield return this[i];
        }
        public IEnumerable<T> SubstringEnum(string str)
        {
            for (int i = 0; i < Count -1 ; i++)
            {
                if (this[i].ToString().Contains(str))
                {
                    yield return this[i];
                }
            }
        }

        public IEnumerable<T> SortedEnum()
        {
            T[] tempArr = (T[])Container.Clone(); 
            T temp;
            for (int i = 0; i < Count; i++)
            {

                for (int j = 0; j < Count - 1; j++)
                {
                    if (tempArr[i].CompareTo(tempArr[j]) == -1)
                    {
                        temp = tempArr[i];
                        tempArr[i] = tempArr[j];
                        tempArr[j] = temp;
                    }               

                }
            }

            for (int i = 0; i < Count; i++)
            {
                yield return tempArr[i];
            }
        }



        public override string ToString()
        {
            string str = "";

            foreach (var el in Container)
            {
                str += $"{el.ToString()} \n";
            }
            return str;
        }


    }
}



//public T this[decimal p]
//{
//    get
//    {
//        foreach (T el  in Container )                    
//        {

//            if (el.Price == p)
//                return el;

//        }
//        throw new ArgumentException("Не найдено");


//    }
//}

//public T this[string s]
//{

//    get
//    {
//        foreach (var el in Container)
//        {

//            if (el.Name == s)
//                return el;

//        }

//        throw new ArgumentException("Не найдено");

//    }
//}
