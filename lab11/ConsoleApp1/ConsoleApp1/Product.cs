using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    

    public class Product<T>: IName<T>
        where T: IComparable, IComparable<T>
    {
        private T name;
        private decimal price;
        public T Name
        {
            get => this.name;
            set
            {
                this.name = value;
            }
        }

        public decimal Price
        {
            get => this.price;
            set
            {
                this.price = value;
            }
        }

        public Product(T name, decimal price)
        {
            Name = name;
            Price = price;
        }      
        


        /// <summary>
        /// virtual
        /// </summary>
        public override string ToString()
        {
            return $"Name: {Name} Price: {Price}"; 
        }

        public int CompareTo(object obj)
        {
            Product<T> p = obj as Product<T>;

            if (p != null)
                return this.Name.CompareTo(p.name);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }

        public int CompareTo(T other)
        {
            Product<T> p = other as Product<T>;

            if (p != null)
                return this.Name.CompareTo(other);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }
}