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
           //first Test 1.2 the maximum number position is at 1st place
            int output2 = MaximumNumberCheck.MaximumIntegerNumber(28, 823, 121);
            Console.WriteLine(output);
            //first Test 1.3 the maximum number position is at 1st place
            int output3 = MaximumNumberCheck.MaximumIntegerNumber(121, 28, 823);
            Console.WriteLine(output);
            
            
            // for float values checking maximum number
            double doubleoutput4 = MaximumNumberCheck.MaximumFloatNumber(1.1, 1.2, 1.3);
            Console.WriteLine(doubleoutput4);
            




        }
    }
}
