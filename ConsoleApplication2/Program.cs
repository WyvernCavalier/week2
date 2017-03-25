using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        private static string input = "nil";
        private static Int32 number;
        private static List<Int32> used=new List<int>();
        static void Main(string[] args)
        {
            while (true)
            {
                //used.Add(0);
                Input_Number();
                if (Int32.TryParse(input, out number))
                {
                    for (Int32 i = 1; i <= number; i++)
                    {
                        if(number%i==0&&!used.Contains(i))
                        {
                            Int32 j = number / i;
                            Console.WriteLine(Convert.ToString(i)+"\t*\t"+ Convert.ToString(j)+ "\t=\t"+ Convert.ToString(number));
                            used.Add(i);
                            used.Add(j);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("you didn't give a valid number");
                }
                input = "nil";
                used.Clear();
            }
        }
        static void Input_Number()
        {
            Console.WriteLine("Please input your number, or'quit' to quit >");
            input = Console.ReadLine();
            if (input == "quit")
                Environment.Exit(0);
        }
    }
}
