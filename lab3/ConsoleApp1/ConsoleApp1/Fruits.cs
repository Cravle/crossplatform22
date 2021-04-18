using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Fruits<T>: Product<T>
        where T : IComparable, IComparable<T>
    {
        
        private decimal weight;
        public Fruits(decimal weight, T name, decimal price) : base(name, price)
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
            return $"Name: {Name} Price: {Price}грн Weight: {Weight}кг";
            
        }
    }
}