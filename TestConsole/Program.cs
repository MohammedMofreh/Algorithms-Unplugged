using System;
using TestConsole.HelperClasses;

class Program
{
    static void Main()
    {
        #region BinarySearch
        string[] cds = { "AC/DC", "Aaliyah", "Alicia Keys", "Kelly Family", "Lionel Hampton", "Nancy Sinatra", "Nelly", "Rachmaninov" };

        string target = "Nelly";

        int result = BinarySearchHelper.BinarySearch(cds, target);

        if (result != -1)
            Console.WriteLine($"Found '{target}' at position {result}.");
        else
            Console.WriteLine($"'{target}' not found.");
        #endregion

        #region InsertionSort
        int[] numbers = { 11, 5, 7, 3, 6, 9, 1 };

        InsertionSortHelper.InsertionSort(numbers);

        Console.WriteLine("Sorted array:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        #endregion

        #region MergeSort
        int[] mergeArray = { 5, 3, 8, 4, 2, 7, 1, 6 };

        Console.WriteLine("\nOriginal Array:");
        SharedHelper.PrintArray(mergeArray);

        MergerSortHelper.MergeSort(mergeArray, 0, mergeArray.Length - 1);
        Console.WriteLine("\nAfter MergeSort:");
        SharedHelper.PrintArray(mergeArray);

        #endregion

    }

    
  
    

}
