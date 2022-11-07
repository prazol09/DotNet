using System;

namespace CalculatorMethods
{
    class Calculator
    {
        public double add(double a, double b)
        {
              return a + b;
        }

        public double diff(double a, double b)
        {
            return a - b;
        }

        public double pro(double a, double b)
        {
            return a * b;
        }

        public double div(double a, double b)
        {
            return a / b;
        }

        // method to print the output
        public void printer(double result)
        {
            Console.Write("-------------------------\nresult is : " + result + "\n-------------------------");
        }

        public void calculator ()
        {
            while (true) // infinite loop because that is how calculators normally are
            {
                Console.Write("\nOPTIONS: \nCODE    operation type\n1       +\n2       -\n3       *\n4       /\nEnter CODE for operation type: ");
                String operation_type = Console.ReadLine();
                Console.Write("Enter a number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());     // fails for negative input cannot convert '-5' to -5
                Console.Write("Enter another number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (operation_type == "1")
                {
                    printer(add(num1, num2));
                }
                else if (operation_type == "2")
                {
                    printer(diff(num1, num2));
                }
                else if (operation_type == "3")
                {
                    printer(pro(num1, num2));
                }
                else if (operation_type == "4")
                {
                    printer(div(num1, num2));
                }
            }
        }
    }
}