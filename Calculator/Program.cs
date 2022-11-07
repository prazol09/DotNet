using System;
using static CalculatorMethods.Calculator;
using static OperatorsA.OddEvenChecker;
using static OperatorsA.SwapNumbers;
using static OperatorsA.LinearSearch;
using static OperatorsA.PrimeChecker;


namespace SharpCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            // function to calculator function called here
            // non-static method so, object is required to call it
            //CalculatorMethods.Calculator obj = new CalculatorMethods.Calculator();

            //obj.calculator();

            //ControlStmts.ControlStatememts objj = new ControlStmts.ControlStatememts();
            //objj.condtStmts();
            //objj.switchstm();
            //objj.whileL();
            //objj.doWhileL();
            //objj.forEach();

            //OperatorsA.OddEvenChecker obj1 = new OperatorsA.OddEvenChecker();
            //Console.Write("Enter a number: ");
            //int aa = Convert.ToInt32(Console.ReadLine());
            //bool a = obj1.isEvenNumber(aa);

            //if (a) { Console.WriteLine(aa + " is an even number");}
            //else {Console.WriteLine(aa + " is an odd number");}


            //OperatorsA.SwapNumbers obj1 = new OperatorsA.SwapNumbers();

            //Console.Write("Enter a number: ");
            //int aa = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter another number: ");
            //int ab = Convert.ToInt32(Console.ReadLine());

            //obj1.numberSwapper(aa, ab);

            //OperatorsA.LinearSearch oj = new OperatorsA.LinearSearch();
            //Console.Write("Enter a metal: ");
            //string aa = Console.ReadLine();
            //bool a = oj.isInArray(aa);

            //console.writeline("is in array: " + a);
            //Console.Write(! (5 % 5 == 0));

            int[] primesN = { 379, 383, 10, 25, 389, 397, 401, 569 };

            OperatorsA.PrimeChecker obj1 = new OperatorsA.PrimeChecker();
            obj1.primeDetector(22);
            //for(int i = 0; i < primesN.Length; i++)
            //{
            //    obj1.primeDetector(primesN[i]);
            //}
        }
    }
}
