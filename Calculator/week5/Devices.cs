using System;

namespace week4
{
    class Devices
    {
        private string _size = "Large";

        public Devices(string s)
        {
            _size = s;
        }

        public void Intro()
        {
            Console.WriteLine($"I am a {_s} Electronic device");
        }
    }

}