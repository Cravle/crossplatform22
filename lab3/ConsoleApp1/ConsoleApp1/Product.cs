using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    

    public class Product: IName
    {
        private string name;
        private decimal price;

        public Product()
        {
            Name = "молоко";
            Price = 19.50M;
        }


        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

            public Product(decimal price)
        {
            Name = "молоко";
            Price = price;
        }

        public Product(string name)
        {
            Name = name;
            Price = 19.50M;
        }

        


        public string Name
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

       

        /// <summary>
        /// virtual
        /// </summary>
        public override string ToString()
        {
            return $"Name: {Name} Price: {Price}грн"; 
        }

        public int CompareTo(object obj)
        {
            Product p = obj as Product;

            if (p != null)
                return this.Name.CompareTo(p.name);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }
}