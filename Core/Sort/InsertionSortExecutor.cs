namespace Core.Sort
{
    /// <summary>
    /// Insertion sort. Chapter 2.1
    /// </summary>
    public static class InsertionSortExecutor
    {
        public static int[] InsertionSort(this int[] nums)
        {
            if(nums == null || nums.Length <= 1){
                return nums;
            }
            for (int i = 0; i < nums.Length; i++) {
                var key = nums[i];
                int j = i - 1;
                while(j >= 0 && nums[j] > key)
                {
                    nums[j + 1] = nums[j];
                    j--;
                }
                nums[j + 1] = key;
            }
            return nums;
        }
    }
}
