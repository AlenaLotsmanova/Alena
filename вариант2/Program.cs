using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace вариант2
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
