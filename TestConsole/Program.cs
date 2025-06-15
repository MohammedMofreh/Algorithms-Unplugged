using System;

class Program
{
    static void Main()
    {
        #region BinarySearch
        string[] cds = { "AC/DC", "Aaliyah", "Alicia Keys", "Kelly Family", "Lionel Hampton", "Nancy Sinatra", "Nelly", "Rachmaninov" };

        string target = "Nelly";

        int result = BinarySearch(cds, target);

        if (result != -1)
            Console.WriteLine($"Found '{target}' at position {result}.");
        else
            Console.WriteLine($"'{target}' not found.");
        #endregion

        #region InsertionSort
        int[] numbers = { 11, 5, 7, 3, 6, 9, 1 };

        InsertionSort(numbers);

        Console.WriteLine("Sorted array:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        #endregion

        #region MergeSort
        int[] mergeArray = { 5, 3, 8, 4, 2, 7, 1, 6 };

        Console.WriteLine("\nOriginal Array:");
        PrintArray(mergeArray);

        MergeSort(mergeArray, 0, mergeArray.Length - 1);
        Console.WriteLine("\nAfter MergeSort:");
        PrintArray(mergeArray);

        #endregion


    }

    static void InsertionSort(int[] A)
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
    static int BinarySearch(string[] array, string key)
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

    static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            MergeSort(array, left, mid);
            MergeSort(array, mid + 1, right);
            Merge(array, left, mid, right);
        }
    }

    static void Merge(int[] array, int left, int mid, int right)
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

    static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(" ", array));
    }


}
