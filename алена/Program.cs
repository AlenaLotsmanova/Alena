using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TZ
{
    public class Program 
    {
        public bool razdelenie(string[] split)
        {

            try
            {
                string t = split[1];
                string s = Convert.ToString(split[0].ToUpper()[0]);
                string j = Convert.ToString(split[1].ToUpper()[t.Length - 1]);
                if (s == j)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }
        static void Main(string[] args)
        {
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
                Program f = new Program();
                bool res = f.razdelenie(split);
                if (res == true)
                {
                    Console.WriteLine("истина");
                }
                else
                {
                    Console.WriteLine("ложь");
                }
                Console.ReadLine();
            }
        }
        
    }
}




// постараться избавиться от лишних классов
    // в тестах постараться убрать строковый вывод