using System;

namespace Conditiona_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Experience");
                string years = Console.ReadLine();
                int years_of_exp = Int32.Parse(years);
                switch (years_of_exp)
                {
                    case 0:
                        Console.WriteLine("Need lot of practice");
                        break;
                    case 1:
                        Console.WriteLine("Looks like you have little experience");
                        break;
                    case 2:
                        Console.WriteLine("Wow You've been doing this for a little while");
                        break;
                    default:
                        Console.WriteLine("You are an expert");
                        break;
                }
            }
            catch(InvalidCastException )
            {
                Console.WriteLine("Try giving the years of experience in string");
            }

        }
    }
}
