using System;

namespace MinMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 5, -3, 0, -9, 12, 24 };
            Console.WriteLine(Min(nums));
        }
        static int Min(int[] nums)
        {
            int min = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]<min)
                {
                    min = nums[i];
                }
            }
            return min;
        }
    }
}
