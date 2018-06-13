using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeApp
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 123");
            Console.WriteLine("Hourly Rate?");
            var answer1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            var answer2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            var answer3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            var answer4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine((answer1 * answer2) > (answer3 * answer4));
        }
    }
}
