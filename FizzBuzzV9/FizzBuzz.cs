using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzV9
{
    public class FizzBuzz
    {
        public string NumEval(int num)
        {
            string output = "";
            int[] numArray = { num };
            if (numArray.Where(n => n % 3 == 0).Any())
            {
                output = "Fizz";
            }

            if (numArray.Where(n => n % 5 == 0).Any())
            {
                output += "Buzz";
            }
            else if (numArray.Where(n => n % 5 != 0 && n % 3 != 0).Any())
            {
                output = num.ToString();
            }

            return output;
        }
    }
}
