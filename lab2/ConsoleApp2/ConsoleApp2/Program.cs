using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static bool isOdd(int[] item)
        {
            int sum = 0;
            foreach(var i in item)
            {
                sum += i;
            }

            if (sum % 2 == 0)
            {

                return true;
            }

            return false;
        }
        static void Main(string[] args)
        { 
            Console.WriteLine("Введите количество строк равного массива");
            int M = Convert.ToInt32( Console.ReadLine());


            
            int[][] arr = new int[M][];
            int sum = 0;
            int N = 0;



            
            for (int i = 0; i < M; i++)
            {
                sum = 0;
                Console.Write($"{i}: ");
                string str = Console.ReadLine();
                string[] newStr = str.Split(' ');
                arr[i] = new int[newStr.Length];

                for(int j = 0; j< newStr.Length; j++)
                {
                    arr[i][j] = Convert.ToInt32( newStr[j]);
                    

                }
                if (isOdd(arr[i]))
                {
                    N++;
                }

            }
            
            int[][] newArr = new int[N][];
            int k = 0;

            void FillNewArr(int[] item)
            {
                newArr[k] = new int[item.Length];
                newArr[k] = item;
                k++;
            }

            for (int j = 0; j < arr.Length; j++)
            {
                sum = 0;
                for (int i = 0; i < arr[j].Length; i++)
                {
                    sum += arr[j][i];

                }
                    if (isOdd(arr[j]))
                    {
                        FillNewArr(arr[j]);
                    }
                
                
            }

            Console.WriteLine("Начальный массив");
            foreach (var str in arr)
            {
                foreach(var el in str)
                {
                    Console.Write(el + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Новый массив");
            foreach (var str in newArr)
            {
                foreach (var el in str)
                {
                    Console.Write(el + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
