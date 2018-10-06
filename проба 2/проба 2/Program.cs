using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace проба_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "0";
            string j = "0";
            int count = 0;
            string[] split = null;
            while (true)
            {
                Console.WriteLine("Введите слова");
                string str = Console.ReadLine();

                split = str.Split(' ');
                
                {
                    break;
                }
            }

            foreach (var t in split)
            {
                //Console.WriteLine("{0}", t);

                if (count == 0)
                    s = Convert.ToString(t[0]);
                if (count == 1)
                {
                    int u = t.Length;
                    j = Convert.ToString(t[u - 1]);
                }


                count++;
            }

            if (s == j)
            {
                Console.WriteLine("Первая буква первого слова и последняя буква второго слова совпадают! :)");
            }
            else
            {
                Console.WriteLine("Первая буква первого слова и последняя буква второго слова не совпадают! :( ");
            }

            Console.ReadLine();
        }
    }
}
