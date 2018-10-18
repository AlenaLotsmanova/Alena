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
                string str = Console.ReadLine(); //преобразование всех букв в большой регистр
                split = str.Split(' ');
                if (split.Length == 2)
                {
                    break;
                }
                Sum d = new Sum();
                str = d.Nana(split);
                Console.WriteLine(str);
            }
            
             Console.ReadLine();
            
        }
    }
    public class Sum
    {
        public string Nana(string[] split)
        {
            try
            {
                string t = split[1];
                string s = Convert.ToString(split[0].ToUpper()[0]);
                string j = Convert.ToString(split[1].ToUpper()[t.Length - 1]);
                if (s == j)
                {
                    return "истина";
                }
                else
                {
                    return "ложь";
                }
            }
            catch (Exception)
            {
                return "Вы ошиблись";
            }
            

            
            
        }
    }
}
       
            
        
   

            
       

