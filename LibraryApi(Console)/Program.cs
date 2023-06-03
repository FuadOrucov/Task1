using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApi_Console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryApp app = new LibraryApp();

            //muellif elave etmek
            app.AddAuthor("Muellif");
            app.AddAuthor("Muellif1");
            app.AddAuthor("Muellif2");

            Console.WriteLine("-----------------");
            //kitab elave etmek
            app.AddBook(0, 0, "Kitab");
            app.AddBook(1, 1, "Kitab1");
            app.AddBook(0, 2, "Kitab2");
            app.AddBook(2, 3, "Kitab3");

            Console.WriteLine("-----------------");

            //kitablari getirmek
            app.GetBook(2);

            Console.WriteLine("-----------------");

            //kitablari deyisdirmek
            app.UpdateBook(1, "Yeni kitab");
            Console.WriteLine("-----------------");


            // kitablari silmek
            app.DeleteBook(0);
            Console.WriteLine("-----------------");
            //ada gore getirmek

            app.SourchByAuthor("Muellif");


            Console.ReadLine();
        }
    }
}
