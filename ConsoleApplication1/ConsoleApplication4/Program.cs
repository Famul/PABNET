using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
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
        }
    }
}
