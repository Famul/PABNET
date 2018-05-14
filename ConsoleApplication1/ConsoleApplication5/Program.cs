using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var zapytanie = from x in db.Products
                            where (x.UnitPrice > 50)
                            where (x.UnitPrice < 100)
                            orderby x.UnitPrice
                            select x;
            foreach (var x in zapytanie)
            {
                Console.WriteLine("Dane: {0} {1}", x.ProductName, x.UnitPrice);
            }
            Console.WriteLine();

            var zapytanie2 = from prod in db.Products
                             join cat in db.Categories on prod.CategoryID equals cat.CategoryID
                             where (prod.UnitPrice > 50)
                             where (prod.UnitPrice < 100)
                             orderby prod.UnitPrice
                             select new { prod.ProductName, cat.CategoryName, prod.UnitPrice };

            foreach (var x in zapytanie2)
            {
                Console.WriteLine("Dane: {0} {1} {2}", x.ProductName, x.CategoryName, x.UnitPrice);
            }
            Console.WriteLine();
            var zapytanie3 = from x in db.View_1s
                             where (x.UnitPrice > 50)
                             where (x.UnitPrice < 100)
                             orderby x.UnitPrice
                             select x;
            foreach (var x in zapytanie3)
            {
                Console.WriteLine("Dane: {0} {1} {2}", x.ProductName, x.CategoryName, x.UnitPrice);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
