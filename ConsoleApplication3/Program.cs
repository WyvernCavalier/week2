using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // could use loop to check the input but leave them for next week tasks
            Console.Write("What is your family name? ");
            string familyName = Console.ReadLine();
            Console.Write("What is your given name? ");
            string givenName = Console.ReadLine();
            Console.Write("What is your title (Mr, Mrs, Miss, Ms, etc.)? ");
            string title = Console.ReadLine();
            Console.Write("What is your country of birth? ");
            string country = Console.ReadLine();
            Console.Write("What languages do you speak? ");
            string languages = Console.ReadLine();
            /*
            Console.WriteLine("{0}", new string('*', 50));
            Console.WriteLine("{0,10}{1,6}{2}", "Field", " ", "Value");
            Console.WriteLine("{0,10}{1,6}{2} {3} {4}", "Name", " ", title,
            givenName, familyName);
            Console.WriteLine("{0,10}{1,6}{2}", "Born In", " ", country);
            Console.WriteLine("{0,10}{1,6}{2}", "Speaks", " ", languages);
            Console.WriteLine("{0}", new string('*', 50));
            */
            Person testPerson = new Person(title, familyName, givenName,
            country, languages);
            Console.WriteLine(testPerson);
        }
    }
}
