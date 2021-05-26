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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Container;

namespace ConsoleApp1
{
    class Program
    {
        static void SaveBinary(Arr<Product<string>> bin)
        {

            FileStream fs = new FileStream("DatFile.dat", FileMode.Create);

            BinaryWriter fff = new BinaryWriter(fs);
            fff.Write(bin.ToString());

            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(bin.ToString());

            }


            fs.Close();

        }
        static Arr<Product<string>> LoadBinary()
        {
            Arr<Product<string>> temp = new Arr<Product<string>>();

            using (BinaryReader reader = new BinaryReader(File.Open("DatFile.dat", FileMode.Open, FileAccess.Read)))
            {


                string strFile = reader.ReadString();
                string[] str = strFile.Split(' ');
                for (int i = 1; i < str.Length; i = i + 4)
                {
                    temp.Add(new Product<string>(str[i], decimal.Parse(str[i+2])));

                }
               

            }

            return temp;
        }
        static void Main(string[] args)
        {
            var arr = new Arr<Product<string>>();

            arr.CountTotal += Arr_CountTotal; ;
            arr.Add(new Product<string>("Греча",15));
            arr.Add(new Product<string>("Молоко",20));
            arr.Add(new Product<string>("Ананас", 3));
            arr.Add(new Product<string>("Апельсин", 5));
            arr.Add(new Product<string>("Лимон", 40));
            arr.Add(new Product<string>("Мандарин", 20));
            arr.Add(new Product<string>("Картофель", 20));
            Console.WriteLine(arr);




            arr.Delete(0);

            arr[0] = new Product<string>("Киви", 115);


            Console.ReadLine();
        }

        private static void Arr_CountTotal(object sender, EventArgs e)
        {
            Console.WriteLine($"Общая сумма: {((Arr<Product<string>>)sender).Total}");
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


//foreach (var el in arr.InverseEnumerator())
//{
//    Console.WriteLine(el);
//}

//Console.WriteLine("------------------------------------");

//foreach (var el in arr.SubstringEnum("Мол"))
//{
//    Console.WriteLine(el);
//}

//Console.WriteLine("------------------------------------");
//foreach (var el in arr.SortedEnum())
//{
//    Console.WriteLine(el);
//}

//Console.WriteLine("------------------------------------");

//var list = new DplxList<Product<string>>();
//list.Add(new Product<string>("Греча", 15));
//list.Add(new Product<string>("Молоко", 20));
//list.Add(new Product<string>("Ананас", 3));
//list.Add(new Product<string>("Апельсин", 5));
//list.Add(new Fruits<string>(1.5M, "Макароны", 7));
//list.Add(new Citrus<string>(13.6M, 1.8M, "Лимон", 10));


////list.Print();
//foreach (var el in list)
//{
//    Console.WriteLine(el);
//}



//SaveBinary(arr);

//arr.Add(new Citrus<string>(13.6M, 1.8M, "Лимон", 10));
//Console.WriteLine("------------------------------------");
//Console.WriteLine(arr);
//Console.WriteLine("------------------------------------");

//arr = LoadBinary();

//arr.Sort((x, y) => x.CompareTo(y));
//Console.WriteLine("Результат делегата для Sort");
//Console.WriteLine(arr);

//Console.WriteLine("Результат делегата для Find, находит первый товар с названием указанным вторым параметром в функции");
//arr.Find((x, y) => x.Name.CompareTo(y), "Лимон");

//Console.WriteLine("Результат делегата для FindAll, находит первый товар с ценной указанной вторым параметром в функции");
//arr.FindAll((x, y) => x.Price.CompareTo(y), 20);