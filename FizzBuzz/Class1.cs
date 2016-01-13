using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzDemo
{
    public class FizzBuzz
    {
        public void IterateTo100()
        {
            for (var x = 1; x <= 100; x++)
            {
                if (CheckMultipleOfFiveAndThree(x))
                {
                    Debug.WriteLine(x + " FizzBuzz");
                }
                else if (CheckMultipleOfThree(x))
                {
                    Debug.WriteLine(x + " Fizz");
                }
                else if (CheckMultipleOfFive(x))
                {
                    Debug.WriteLine(x + " Buzz");
                }
                else
                {
                    Debug.WriteLine(x);
                }
            }
        }

        public bool CheckMultipleOfThree(int checkThree)
        {
            return ((checkThree%3) == 0);
        }

        public bool CheckMultipleOfFive(int checkFive)
        {
            return ((checkFive%5) == 0);
        }

        public bool CheckMultipleOfFiveAndThree(int checkFiveAndThree)
        {
            return (CheckMultipleOfThree(checkFiveAndThree) && CheckMultipleOfFive(checkFiveAndThree));
        }
    }
}