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
            
            Console.Write("menu:\ncalc\tcontrlstmts\toddeven\nswap\tlsearch\tfprime\nEnter a program: ");
            string pp = Console.ReadLine();

            switch (pp)
            {
                case "calc":
                    // function to calculator function called here
                    CalculatorMethods.Calculator obj = new CalculatorMethods.Calculator();
                    obj.calculator();
                    break;
                case "contrlstmts":
                    ControlStmts.ControlStatememts objj = new ControlStmts.ControlStatememts();
                    objj.condtStmts();
                    //objj.switchstm();
                    //objj.whileL();
                    //objj.doWhileL();
                    //objj.forEach();
                    break;
                case "oddeven":
                    OperatorsA.OddEvenChecker obj1 = new OperatorsA.OddEvenChecker();
                    Console.Write("Enter a number: ");
                    int aa = Convert.ToInt32(Console.ReadLine());
                    bool a = obj1.isEvenNumber(aa);
                    
                    if (a) { Console.WriteLine(aa + " is an even number");}
                    else {Console.WriteLine(aa + " is an odd number");}
                    break;
                case "swap":
                    OperatorsA.SwapNumbers obj2 = new OperatorsA.SwapNumbers();

                    Console.Write("Enter a number: ");
                    int ac = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter another number: ");
                    int bc = Convert.ToInt32(Console.ReadLine());

                    obj2.numberSwapper(ac, bc);
                    break;
                case "lsearch":
                    OperatorsA.LinearSearch oj = new OperatorsA.LinearSearch();
                    Console.Write("Enter a metal: ");
                    string aac = Console.ReadLine();
                    bool af = oj.isInArray(aac);

                    Console.WriteLine("is in array: " + af);
                    // Console.Write(! (5 % 5 == 0));
                    break;
                case "fprime":
                    int[] primesN = { 379, 383, 10, 25, 389, 397, 401, 569 };

                    OperatorsA.PrimeChecker obj3 = new OperatorsA.PrimeChecker();

                    Console.Write("Enter a number: ");
                    int accc = Convert.ToInt32(Console.ReadLine());
                    obj3.primeDetector(accc);
                    //for(int i = 0; i < primesN.Length; i++)
                    //{
               //    obj1.primeDetector(primesN[i]);
            //}
                    break;
            }

        }
    }
}
