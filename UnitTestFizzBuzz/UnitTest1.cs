using System;
using FizzBuzzDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFizzBuzz
{
    [TestClass]
    public class UnitTest1
    {
        //"Write a program that prints the numbers from 1 to 100. 
        //But for multiples of three print “Fizz” and 
        //for the multiples of five print “Buzz”. 
        //For numbers which are multiples of both three and five print “FizzBuzz”."
        [TestMethod]
        public void TestFizzBuzzIterate()
        {
            var fizzbuzz = new FizzBuzz();
            Assert.IsNotNull(fizzbuzz);
            fizzbuzz.IterateTo100();
        }

        [TestMethod]
        public void TestFizzBuzzMultiplesOfThreeTrue()
        {
            var fizzbuzz = new FizzBuzz();
            Assert.IsTrue(fizzbuzz.CheckMultipleOfThree(9));
        }

        [TestMethod]
        public void TestFizzBuzzMultiplesOfThreeFalse()
        {
            var fizzbuzz = new FizzBuzz();
            Assert.IsFalse(fizzbuzz.CheckMultipleOfThree(10));
        }
        [TestMethod]
        public void TestFizzBuzzMultiplesOfFiveTrue()
        {
            var fizzbuzz = new FizzBuzz();
            Assert.IsTrue(fizzbuzz.CheckMultipleOfFive(55));
        }

        [TestMethod]
        public void TestFizzBuzzMultiplesOfFiveFalse()
        {
            var fizzbuzz = new FizzBuzz();
            Assert.IsFalse(fizzbuzz.CheckMultipleOfFive(8));
        }
        [TestMethod]
        public void TestFizzBuzzMultiplesOfFiveAndThreeTrue()
        {
            var fizzbuzz = new FizzBuzz();
            Assert.IsTrue(fizzbuzz.CheckMultipleOfFiveAndThree(30));
        }

        [TestMethod]
        public void TestFizzBuzzMultiplesOfFiveAndThreeFalse()
        {
            var fizzbuzz = new FizzBuzz();
            Assert.IsFalse(fizzbuzz.CheckMultipleOfFiveAndThree(8));
        }
    }
}