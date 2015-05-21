using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzV9
{
    class Program
    {
        static void Main(string[] args)
        {
            NumWriter();
        }

        public static void NumWriter()
        {
            Console.WriteLine("What number would you like to go up to?");
            
            var input = Console.ReadLine();
            int inputNum;
            Int32.TryParse(input, out inputNum);

            var fb = new FizzBuzz();

            (from n in Enumerable.Range(1, inputNum)
             select n)
            .ToList().ForEach(n => Console.WriteLine(fb.NumEval(n)));
        }


    }
}
