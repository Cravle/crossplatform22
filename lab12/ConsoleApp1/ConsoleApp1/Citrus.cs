using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Citrus<T>: Fruits<T>
        where T : IComparable, IComparable<T>
    {

        public Citrus(decimal sugar, decimal weight, T name, decimal price) : base(weight, name, price)
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