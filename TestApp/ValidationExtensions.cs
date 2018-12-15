namespace TestApp
{
    using System;

    public class ValidationExtensions
    {
        public static bool CheckArrayAscending(int[] nums)
        {
            if(nums == null || nums.Length == 0)
            {
                return true;
            }
            for(int i = 1; i < nums.Length; i++)
            {
                if(nums[i] < nums[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
