using System;
using static CalculatorMethods.Calculator;

namespace SharpCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            // function to calculator function called here
            // non-static method so, object is required to call it
            CalculatorMethods.Calculator obj = new CalculatorMethods.Calculator();
           
            obj.calculator();

            //ControlStmts.ControlStatememts objj = new ControlStmts.ControlStatememts();
            //objj.condtStmts();
            //objj.switchstm();
            //objj.whileL();
            //objj.doWhileL();
            //objj.forEach();

        }
    }
}
