using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Fruits: Product
    {
        
        private decimal weight;

        public Fruits()
        {
            Weight = 1.5M;
        }

        public Fruits(string name = "Яблоко", decimal price = 19.50M): base(name, price)
        {
            
            Weight = 1.0M;
        }

        public Fruits(decimal weight, string name = "Яблоко", decimal price = 19.50M) : base(name, price)
        {

            Weight = weight;
        }

        public decimal Weight
        {
            get => this.weight;
            set
            {
                this.weight = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name} Price: {Price} Weight: {Weight}";

        }
    }
}