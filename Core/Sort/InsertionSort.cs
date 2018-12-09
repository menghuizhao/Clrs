namespace Core.Sort
{
    public class InsertionSort
    {
        public void SortInPlace(int[] nums)
        {
            if(nums == null || nums.Length <= 1){
                return;
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

        }
    }
}
