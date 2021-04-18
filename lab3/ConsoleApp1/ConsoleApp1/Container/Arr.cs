using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Container
{
    public class Arr<T>
        where T: IComparable
    {
        private T[] Container;
        public int Count {get;set;}
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
                for(int i = 0; i < Count - 1; i++)
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
            while(i <= Count)
            {
                if(i != index)
                {
                    temp[j] = Container[i];
                    j++;
                }
                i++;
            }
            Container = temp;
        }

        public void Sort()
        {
            T temp;
            for(int i = 0; i < Count; i++)
            {

                for (int j = 0; j < Count-1; j++)
                {
                    if(Container[i].CompareTo(Container[j]) == -1)
                    {
                        temp = Container[i];
                        Container[i] = Container[j];
                        Container[j] = temp;
                    }
                }
            }
        }

        public override string ToString()
        {
            string str = "";

            foreach(var el in Container)
            {
               str += $"{el.ToString()} \n";
            }
            return str;
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

        public T this[int i]
        {
            set { Container[i] = value; }
            get {
                if (i >= Count || i < 0)
                {
                    ArrEx e = new ArrEx();
                    e.Data.Add("Index", i);
                    throw e;
                }
                    return Container[i]; 
            }
        }

    }
}
