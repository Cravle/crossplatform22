using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Container
{
    public class Arr
    {
        private Product[] Container;
        public int Count {get;set;}
        private int Size = 5;
        public Arr()
        {
            Count = 0;
            Container = new Product[Size];
        }

        public void Add(Product P)
        {
            if (Count < Size)
            {
                Container[Count] = P;
                Count++;
            }
            else
            {
                Product[] temp = new Product[++Count];
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
            Product[] temp = new Product[--Count];
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
            Product temp;
            for(int i = 0; i < Count - 1; i++)
            {

                for (int j = 0; j < Count; j++)
                {
                    if(Container[i].Price > Container[j].Price)
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

        public Product this[decimal p]
        {
            get
            {
                foreach (var el in Container)
                {
                    if (el.Price == p)
                        return el;

                }

                return new Product("Нет результатов с такой ценой", 0);
            }
        }

        public Product this[string s]
        {
           
            get
            {
                foreach (var el in Container)
                {
                    if (el.Name == s)
                        return el;
                    
                }

                return new Product($"no {s}", 0);
            }
        }

        public Product this[int i]
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
