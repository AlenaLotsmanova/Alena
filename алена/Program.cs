using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TZ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] split = null;
            while (true)
            {
                Console.WriteLine("Введите два слова");
                string str = Console.ReadLine().ToUpper(); //преобразование всех букв в большой регистр
                split = str.Split(' ');
                if (split.Length == 2)
                {
                    break;
                }
            }
            string t = split[1];
            string s = Convert.ToString(split[0][0]);
            string j = Convert.ToString(split[1] [t.Length - 1]); 

                if (s == j)
                {Console.WriteLine("истина");}
                else
                { Console.WriteLine("ложь");}
                { Console.ReadLine();}
            }
        }
    }

            
       

