using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace ConsoleSuffixCalculator
{
    class Program
    {
        /// <summary>
        /// Виклик бібліотечного метода 
        /// </summary>
       
        static void Main(string[] args)
        {
          
            Console.WriteLine("Введіть перше значення");
            String s1 = Console.ReadLine();
            Console.WriteLine("Введіть значення для порівняння");
            String s2 = Console.ReadLine();
                        
            SuffixCalculator suffix = new MyLib.SuffixCalculator();
            var result = suffix.RunSuffixCalculator(s1,s2);
            
            Console.WriteLine("common suffix = {0}", result);
            Console.ReadKey();


        }
    }
}
