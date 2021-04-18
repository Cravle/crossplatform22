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
using ConsoleApp1.Container;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new Arr<Product<string>>();

            arr.Add(new Product<string>("Греча",15));
            arr.Add(new Product<string>("Молоко",20));
            arr.Add(new Product<string>("Ананас", 3));
            arr.Add(new Product<string>("Апельсин", 5));
            arr.Add(new Fruits<string>(1.5M,"Макароны", 7));
            arr.Add(new Citrus<string>(13.6M, 1.8M, "Лимон", 10));
            Console.WriteLine(arr);

            Console.WriteLine("------------------------------------");


            var list = new DplxList<Product<string>>();
            list.Add(new Product<string>("Греча", 15));
            list.Add(new Product<string>("Молоко", 20));
            list.Add(new Product<string>("Ананас", 3));
            list.Add(new Product<string>("Апельсин", 5));
            list.Add(new Fruits<string>(1.5M, "Макароны", 7));
            list.Add(new Citrus<string>(13.6M, 1.8M, "Лимон", 10));


            list.Print();


            Console.ReadLine();
        }
    }
}

//try
//{
//    Console.WriteLine(arr[6].ToString());
//}
//catch(ArrEx e)
//{
//    Console.WriteLine($"Элемент с индексом {e.Data["Index"]} не существует");
//}
//Console.WriteLine(arr["Молоко"].ToString());
//Console.WriteLine(arr[3M].ToString());

//Console.WriteLine(arr[0].Name);

//Console.WriteLine(arr);

//arr.Delete(3);
//Console.WriteLine("------------------------");
//Console.WriteLine(arr);


//arr.Sort();
//Console.WriteLine("------------------------");
//Console.WriteLine(arr);