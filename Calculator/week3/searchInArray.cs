using System;

namespace OperatorsA
{
    class LinearSearch
    {
        public bool isInArray(string str)
        {
            string[] metals = { "iron", "gold", "mercury", "radium" };

            bool a = false;
            for(int i = 0; i < 4; i++)
            {
                if (metals[i] == str) { a = true; }
            }
            return a;
        }
    }
}