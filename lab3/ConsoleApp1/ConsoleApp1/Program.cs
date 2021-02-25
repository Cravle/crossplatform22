/*
    Создать иерархию классов для  хранения и обработки информации о пище
(для продажи данной продукции в магазине).Реализовать класс Product со свойствами string Name 
(имя товара) и decimal Price (стоимость товара). Создать несколько производных классов, которые
должны отличаться набором свойст (набор согласовать с преподавателем). В классах реализовать
конструктор по умолчанию и несколько конструкторов с разным набором параметров. Во всех
разработанных классах должен быть перегружен метод ToString(), которыйт преобразует в строку 
информацию об объекте. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product obj1 = new Product("Овсянка");
            Console.WriteLine(obj1.ToString());
            Fruits obj2 = new Fruits(10.0M,"Овсянка", 24.5M);
            Console.WriteLine(obj2.ToString());

            Citrus obj3 = new Citrus();
            Console.WriteLine(obj3.ToString());

            Console.ReadLine();
        }
    }
}
