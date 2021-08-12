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
            // Test2.1
            double doubleoutput5 = MaximumNumberCheck.MaximumFloatNumber(1.3, 1.2, 1.1);
            Console.WriteLine(doubleoutput4);
            // Test2.2
            double doubleoutput6 = MaximumNumberCheck.MaximumFloatNumber(1.1, 1.3, 1.2);
            Console.WriteLine(doubleoutput4);
            //Test2.3
            double doubleoutput7 = MaximumNumberCheck.MaximumFloatNumber(1.1, 1.2, 1.3);
            Console.WriteLine(doubleoutput4);




            string stringooutput1 = MaximumNumberCheck.MaximumStringNumber("Apple", "Peach", "Banana");
            Console.WriteLine(stringooutput1);
            //Test Case 3.1
            string stringooutput2 = MaximumNumberCheck.MaximumStringNumber("Peach", "Apple", "Banana");
            Console.WriteLine(stringooutput1);
            //Test Case 3.2
            string stringooutput3 = MaximumNumberCheck.MaximumStringNumber("Apple", "Banana", "Peach");
            Console.WriteLine(stringooutput1);
            //Testc Case 3..3
            string stringooutput4 = MaximumNumberCheck.MaximumStringNumber("Apple", "Peach", "Banana");
            Console.WriteLine(stringooutput1);



        }
    }
}
