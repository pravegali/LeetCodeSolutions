using System;

namespace LeetCOde
{
    class Program
    {
        public static void Main(string[] args)
        {
            TwoSum twoSum = new TwoSum();
            Console.WriteLine((twoSum.ReturnTwoSum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 15)).ToString());
        }
    }
}
