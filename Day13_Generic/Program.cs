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

            int[] intArray = { 112, 344, 555 , 457 , 854, 324 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();


            double[] doubleArray = { 11.2, 3.44, 5.55,45.88,5.2,7.8 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();


            string[] stringArray = { "222","777", "444", "120" , "999" };
            GenericMaximum<string> genericstring = new GenericMaximum<string>(stringArray);
            genericstring.PrintMaxValue();

        }
    }
}
