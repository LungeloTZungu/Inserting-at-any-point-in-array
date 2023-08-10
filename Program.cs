using System;

namespace InsertingAnywhereInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[6];
            int length = 0;
             // populating array
            for (int i = 0; i<6; i++)
            {
                intArray[length] = i;
                length++;
            }
            Console.WriteLine("Original Array:");
            foreach(var i in intArray)
            {
                Console.WriteLine(i);
            }

            // Inserting at any point inan arrauy
            for (int i = 4; i >= 2; i--)
            {
                // shifting each element one position to the right

                intArray[i + 1] = intArray[i];

            }
            intArray[2] = 8;
            Console.WriteLine("New Array:");
            foreach(var i in intArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
