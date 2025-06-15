using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.HelperClasses
{
    public class InsertionSortHelper
    {
        #region InsertionSort
        public static void InsertionSort(int[] A)
        {
            int n = A.Length;

            for (int i = 1; i < n; i++)
            {
                int next = A[i];
                int previous = i - 1;

                while (previous >= 0 && A[previous] > next) // shift elements
                {
                    A[previous + 1] = A[previous];
                    previous--;
                }

                A[previous + 1] = next; // insert the next element in the correct position

            }
        }

        #endregion
    }
}
