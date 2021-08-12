using System;
using System.Collections.Generic;

namespace Day13_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Welcoe to  find Maximum Number By using Generic------------------");
             Console.WriteLine("Find Max Number");
            
            int output = MaximumNumberCheck.MaximumIntegerNumber(121, 28, 823);
            Console.WriteLine(output);
           //first Test 1.1 the maximum number position is at 1st place
            int output1 = MaximumNumberCheck.MaximumIntegerNumber(823,28, 121);
            Console.WriteLine(output);
            




        }
    }
}
