using System;

namespace Core.Sort
{
    /// <summary>
    /// Merge sort. Chapter 2.3.1
    /// </summary>
    public static class MergeSortExecutor
    {
        /// <summary>
        /// Entry point.
        /// </summary>
        /// <returns>The sort.</returns>
        /// <param name="nums">Nums.</param>
        public static int[] MergeSort(this int[] nums)
        {
            if (nums == null || nums.Length <= 1)
            {
                return nums;
            }
            return Merge_Sort(nums, 0, nums.Length - 1);

        }

        /// <summary>
        /// Do merge sort for index [p ~ r]
        /// </summary>
        /// <returns>The sort.</returns>
        /// <param name="A">A.</param>
        /// <param name="p">P.</param>
        /// <param name="r">The red component.</param>
        private static int[] Merge_Sort(int[] A, int p, int r)
        {
            if(p < r)
            {
                // Find middle point.
                var q = (p + r) / 2;
                // Do Merge sort for index p ~ q.
                var leftSorted = Merge_Sort(A, p, q);
                // Do Merge sort for index q + 1 ~ r.
                var rightSorted = Merge_Sort(A, q + 1, r);
                // In-place change left & right part of A with the sorted result.
                // Pay attention that leftSorted and rightSorted are full A.Length
                Array.Copy(leftSorted, p, A, p, q - p + 1);
                Array.Copy(rightSorted, q + 1, A, q + 1, r - q);
                // Merge left and right part.
                return Merge(A, p, q, r);
            }
            return A; // p == r
        }
        /// <summary>
        /// p, q and r are indices of A. A[0 ~ p ~ q ~ r]
        /// Suppose that in A, [p,q] and [q+1, r] are sorted. Merge them to A.
        /// </summary>
        /// <returns>The merge.</returns>
        /// <param name="A">The array</param>
        /// <param name="p">P.</param>
        /// <param name="q">Q.</param>
        /// <param name="r">The red component.</param>
        private static int[] Merge(int[] A, int p, int q, int r)
        {
            var n1 = q - p + 1; // left array A[p] ~ A[q]
            var n2 = r - q;     // right array A[q+1] ~ A[r]

            int[] left = new int[n1 + 1];
            for(int i = 0; i < n1; i++)
            {
                left[i] = A[p + i];
            }
            left[n1] = int.MaxValue; //guard

            int[] right = new int[n2 + 1];
            for (int j = 0; j < n2; j++)
            {
                right[j] = A[q + 1 + j];
            }
            right[n2] = int.MaxValue; //guard

            // Scan A from left to right
            int m = 0;
            int n = 0;
            for(int k = p; k <= r; k++)
            {
                if (left[m] <= right[n])
                {
                    A[k] = left[m++];
                }
                else A[k] = right[n++];
            }
            return A;
        }

    }
}
