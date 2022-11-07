namespace ControlStmts
{
     class ControlStatememts
    { 
        public void condtStmts()
        {
            Console.WriteLine("Enter numbers:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            if (a > b)
            {
                Console.Write(a + " is greate then " + b);
            }
            else if (a < b)
            {
                Console.Write($"{a} is smaller then {b}");
            }
            else
            {
                Console.Write(a + " is equal to " + b);
            }
        }

        // if predefined condtns use switch
        public void switchstm()
        {
            Console.Write("Enter any number: ");
            String a = Console.ReadLine();

            switch (a)
            {
                case "1":
                    Console.Write("number one is always good!!");
                    break;
                case "2":
                    Console.Write("number one, not bad.");
                    break;
                default:
                    Console.Write("sorry, not a lucky number!");
                    break;

            }
        }

        public void whileL()
        {
            int i = 0;
            string s = "*";

            while(i < 10)
            {
                
                Console.Write($"{s}\n");
                s += "*";
                i++;
            }
        }

        public void doWhileL()
        {
            
            do
            {
                Console.WriteLine("enter tallest mountain name: ");
                string ans = Console.ReadLine();
            } while ("apple" != "everest");
        }

        public void forEach()
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7};

            for(int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]}  ");
            }

            foreach (int c in myArray)
            {
                Console.WriteLine(Convert.ToString(c));
            }
        }
    }
}