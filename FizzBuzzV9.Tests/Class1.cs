using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Core;
using NUnit.Framework;
using FizzBuzzV9;

namespace FizzBuzzV9.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void FizzCheck()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.NumEval(3);
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void BuzzCheck()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.NumEval(5);
            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void FizzBuzzCheck()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.NumEval(15);
            Assert.AreEqual("FizzBuzz", result);
        }

        [Test]
        public void NotDivisibleByFiveorThree()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.NumEval(11);
            Assert.AreEqual("11", result);
        }
    }
}
