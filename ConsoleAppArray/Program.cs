using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //erol deneme 

            string[] boys = new string[5] 
            {
                "ali",
                "veli",
                "ahmet",
                "mehmet",
                "kerem"
            };

            string[] girls= new string[5]
            {
                  "ayşe",
                  "fatma",
                  "merve",
                  "betül",
                  "dilek"
            };



            string[,] array = new string[,]
            {
                {"cat", "dog","ersoy"},
                {"bird", "fish","ahmet"},
            };

            // ... Print out values.
            Console.WriteLine(array[0, 0]);
            Console.WriteLine(array[0, 1]);
            Console.WriteLine(array[0, 2]);

            Console.Read();


        }
    }
}
