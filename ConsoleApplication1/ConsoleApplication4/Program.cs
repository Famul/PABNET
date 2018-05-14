using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public static class Extension
    {
        public static bool czyParzysta(this int x)
        {
            return x % 2 == 0;
        }
    }
    class Program
    {
        public class numery
        {
            public int a { get; set; }
        }
  
        static void Main(string[] args)
        {
            string[] names = {"Ala", "Adam", "Tomek", "Piotr", "Ewa", "Kamil" };
            var result = from name in names
                         where name.Length < 5
                         orderby name
                         select name.ToUpper();
            foreach(string item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            List<numery> numery = new List<numery>
            {
                new numery { a = 1 },
                new numery { a = 2 },
                new numery { a = 3 }
            };
            var zapytanie = from numer in numery
                            select numer;
            var zapytanie2 = (from numer in numery
                            select numer).ToList();

            numery.Add(new numery() { a = 4 });
            foreach (var x in zapytanie)
            {
                Console.WriteLine(x.a.ToString());
            }
            Console.WriteLine();
            foreach (var x in zapytanie2)
            {
                Console.WriteLine(x.a.ToString());
            }
            Console.WriteLine();
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var zapytanie3 = from z in num
                             where z % 2 == 0
                             orderby z descending
                             select z;
            foreach (var x in zapytanie3)
            {
                Console.WriteLine(x.ToString());
            }
            Console.WriteLine();
            var zapytanie4 = from z in num
                             where z.czyParzysta()
                             orderby z descending
                             select z;
            foreach (var x in zapytanie4)
            {
                Console.WriteLine(x.ToString());
            }
            Console.WriteLine();

            var zapytanie5 = num.GroupBy(a => a.czyParzysta());
            foreach(var x in zapytanie5)
            {
                Console.WriteLine("Czy parzysta = {0}", x.Key); 
                foreach(var item in x)
                {
                    Console.WriteLine("{0}", item);
                }
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
