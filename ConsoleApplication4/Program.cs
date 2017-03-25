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
            // could use loop to check the input but leave them for next week tasks
            Console.Write("Book Title! > ");
            string Title = Console.ReadLine();
            Console.Write("Book Author! > ");
            string Author = Console.ReadLine();
            Console.Write("Book Call Number! > ");
            string CallNum = Console.ReadLine();


            LibraryBook testbook = new LibraryBook(Title, Author, CallNum);
            Console.WriteLine(testbook);
        }
    }
}
