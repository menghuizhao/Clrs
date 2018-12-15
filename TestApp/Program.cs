using System;
using Core.Sort;

namespace TestApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SortTests();
        }
        public static void SortTests(){
            // Insertion sort
            var arr = new int[] { 31, 41, 59, 26, 41, 58 };
            arr.InsertionSort();
            Console.WriteLine(arr);
            // Merge sort
            arr = new int[] { 31, 41, 59, 26, 41, 58 };
            arr.MergeSort();
            Console.WriteLine(arr);
        }
    }
}
