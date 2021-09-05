using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 30, 28, 25, 22, 21, 29, 27, 26, 24 };

            Console.WriteLine("The missing number is: {0}", findMissingnumber(nums));

            Console.ReadKey();
        }

        private static int findMissingnumber(int[]vals)
        {
            int sumArray = 0;
            for (int i = 0; i < vals.Length; i++)
            {
                sumArray += vals[i];
            }

            int expectedSum = 0;
            for(int i = 21; i <= 30; i++)
            {
                expectedSum += i;
            }

            int missingNum;
            missingNum = expectedSum - sumArray;

            return missingNum;
        }
    }
}
