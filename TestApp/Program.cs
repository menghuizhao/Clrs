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
            var arr = new int[] { 31, 41, 59, 26, 41, 58 };
            new InsertionSort().SortInPlace(arr);

        }
    }
}
