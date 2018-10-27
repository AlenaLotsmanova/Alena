using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TZ
{
    public class Program 
    {
        static void Main(string[] args)
        {
            string s = "0";
            string j = "0";
            int count = 0;
            string[] split = null;
            while (true)
            {
                Console.WriteLine("Введите два слова");
                string str = Console.ReadLine(); 

                split = str.Split(' ');
                if (split.Length == 2)
                {
                    break;
                }
            }

            foreach (var t in split)
            {
                if (count == 0)
                    s = Convert.ToString(t[0]);
                if (count == 1)
                {
                    int u = t.Length;
                    j = Convert.ToString(t[u - 1]);
                }
                count++;
            }
            try
            {
                string t = split[1];
                string s = Convert.ToString(split[0].ToUpper()[0]);
                string j = Convert.ToString(split[1].ToUpper()[t.Length - 1]);
                if (s == j)
                {
                    Console.WriteLine("истина");
                }
                else
                {
                    Console.WriteLine("ложь");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ошиблись");
            }
            {
                Console.ReadLine();
            }
        }
    }
 }



// постараться избавиться от лишних классов
    // в тестах постараться убрать строковый вывод