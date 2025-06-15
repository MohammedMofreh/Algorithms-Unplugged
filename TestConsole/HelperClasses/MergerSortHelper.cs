using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.HelperClasses
{
    public class MergerSortHelper
    {
        #region MergeSort
        public static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSort(array, left, mid);
                MergeSort(array, mid + 1, right);
                Merge(array, left, mid, right);
            }
        }

        public static void Merge(int[] array, int left, int mid, int right)
        {
            int[] result = new int[right - left + 1];
            int i = left, j = mid + 1, k = 0;

            while (i <= mid && j <= right)
                result[k++] = (array[i] < array[j]) ? array[i++] : array[j++];

            while (i <= mid) result[k++] = array[i++];
            while (j <= right) result[k++] = array[j++];

            for (int x = 0; x < result.Length; x++)
                array[left + x] = result[x];
        }


        #endregion
    }
}
