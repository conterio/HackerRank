using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues.Interview
{
	public static class MergeSort
	{
		public static void DoSomething()
		{
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Sort(arr, 0, arr.Length - 1);
        }

		private static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // Find the middle
                // point
                int mid = left + (right - left) / 2;

                // Sort first and
                // second halves
                Sort(arr, left, mid);
                Sort(arr, mid + 1, right);

                // Merge the sorted halves
                Merge(arr, left, mid, right);
            }
        }

        private static void Merge(int[] arr, int left, int mid, int right)
        {
            // Find sizes of two
            // subarrays to be merged
            int n1 = mid - left + 1;
            int n2 = right - mid;

            // Create temp arrays
            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                leftArr[i] = arr[left + i];
            for (j = 0; j < n2; ++j)
                rightArr[j] = arr[mid + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarray array
            int k = left;
            while (i < n1 && j < n2)
            {
                if (leftArr[i] <= rightArr[j])
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArr[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                arr[k] = rightArr[j];
                j++;
                k++;
            }
        }


    }
}
