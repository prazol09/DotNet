using System;

namespace OperatorsA
{
    class PrimeChecker
    {
        public void primeDetector(int num1)
        {
            string a = " is not a prime number";
            string b = " is a prime number";

            if (num1 % 2 == 0) { Console.WriteLine(num1 + a); }
            else
            {
                int i = 3;
                bool notPrime = false;
                while (i < num1)
                {
                    Console.WriteLine("--------------->> " + i); // to know the number of steps taken
                    if (num1 % i == 0) { Console.WriteLine(num1 + a); notPrime = true; break; }
                    i += 2;
                }
                if (!notPrime) { Console.WriteLine(num1 + b); }
            }
        }

    }
}
