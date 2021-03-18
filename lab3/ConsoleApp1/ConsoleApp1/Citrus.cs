using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Citrus: Fruits
    {

        public Citrus()
        {
            Sugar = 13.5M;
        }

        public Citrus( string name = "Апельсин", decimal weight = 1.2M, decimal price = 19.50M) : base(weight, name, price)
        {

            Sugar = 13.5M;
        }

        public Citrus(decimal sugar, decimal weight = 1.2M, string name = "Апельсин", decimal price = 19.50M) : base(weight, name, price)
        {

            Sugar = sugar;
        }

        private decimal sugar;

    public decimal Sugar
        {
            get => this.sugar;
            set
            {
                this.sugar = value;
            }
        }

        public override string ToString()
        {
        return $"Name: {Name} Price: {Price}грн Weight: {Weight}кг Sugar: {Sugar}гр";
    }
    }
}