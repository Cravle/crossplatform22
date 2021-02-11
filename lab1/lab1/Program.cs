using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static bool isLetter(char letter)
        {
            char[] vowels = new char[] {  'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U', 'Y', 'y' };
            //string[] consonants = new string[]
            //{   'b', "B", "C", "c", "d", "D", "f", "F", "g", "G",
            //    "H", "h", "J", "j", "K", "k", "L", "l", "M", "m",
            //    "N", "n", "P", "p", "Q", "q", "R", "r", "S", "s",
            //    "T", "t", "V", "v", "W", "w", "X", "x", "y", "Y", "z", "Z"
            //};
            foreach (var l in vowels)
                if (letter == l)
                    return true;
            return false;
        }
        static bool check(string word)
        {
            bool flag = false;
            for (int i = 0; i < word.Length - 1; i++)
            {
                //1st isLetter return true
                if (isLetter(word[i]))
                    if (!isLetter(word[i + 1]))
                        flag = true;
                    else
                        return flag = false;
                //1st isLetter return false
                if (!isLetter(word[i]))
                    if (isLetter(word[i + 1]))
                        flag = true;
                    else
                        return flag = false;

            }

            return flag;
        }

        static void Main(string[] args)
        {
            Console.Write("Write a line:");
            string str = Console.ReadLine();
            string[] newStr = str.Split(' ');
            str = "";
            Console.Write("New line: ");
            foreach (var word in newStr)
            {
                    if (check(word))
                        str += word + " ";
            }
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
