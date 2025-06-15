using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.HelperClasses
{
    public class BinarySearchHelper // Renamed the class to avoid conflict  
    {
        public static int BinarySearch(string[] array, string key)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                int comparison = string.Compare(array[middle], key, StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                    return middle; // Found!  
                else if (comparison > 0)
                    right = middle - 1; // Move to left half  
                else
                    left = middle + 1;  // Move to right half  
            }

            return -1; // Not found  
        }
    }
}
