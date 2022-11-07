using System;

namespace OperatorsA
{
    class SwapNumbers
    {
        public void numberSwapper(int num1, int num2)
        {
            int num3 = num1;
            num1 = num2;
            num2 = num3;

            Console.WriteLine("swapped numbers: " + num1 + " and " + num2);
        }
    }
}