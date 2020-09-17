using System;
using System.Collections.Generic;
using System.Text;

namespace ATMMachine
{
    class Keypad
    {
        public int GetInput()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
