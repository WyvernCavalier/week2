using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static string input="nil";
        private static decimal income;
        private static decimal tax_payable;
        //private static bool quit;
        static void Main(string[] args)
        {
            while (true)
            {
                Input_Income();
                if (decimal.TryParse(input, out income))
                {
                    if (income < 6000)
                    { tax_payable = 0; }
                    else if (income >= 6000 && income < 37000)
                    { tax_payable = (income - 6000) *Convert.ToDecimal(0.15); }
                    else if (income >= 37000 && income < 80000)
                    { tax_payable = (income - 37000) * Convert.ToDecimal(0.30) + 4650; }
                    else if (income >= 80000 && income < 180000)
                    { tax_payable = (income - 80000) * Convert.ToDecimal(0.37) + 17550; }
                    else
                    { tax_payable = (income - 180000) * Convert.ToDecimal(0.45) + 54550; }
                    Console.WriteLine("Your tax payable is " + Convert.ToString(tax_payable));
                }
                else
                {
                    Console.WriteLine("you didn't give a valid income");
                }
                    input = "nil";

    }
}

        static void Input_Income()
        {
            Console.WriteLine("Please input your income amount, or'quit' to quit >");
            input = Console.ReadLine();
            if (input == "quit")
                Environment.Exit(0);
        }
    }
}
