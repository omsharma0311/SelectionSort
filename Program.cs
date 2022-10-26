using System;

namespace SelectionSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] unsortedArray = { 17, 3, 6, 23, 35, 11, 34 };
            Console.WriteLine("Array Before sorting");
            foreach (var item1 in unsortedArray)
            {
                Console.WriteLine(item1); 
            }
            SelectionSort(unsortedArray);
            Console.WriteLine("Array After sorting");
            for (int item2 = 0; item2 < unsortedArray.Length; item2++)
            {
                Console.WriteLine(unsortedArray[item2]);
            }
        }
        public static void SelectionSort(int[] array) 
        {
            int temp;
            for (int item = 0; item < array.Length - 1; item++)
            {
                int minIndex = item;
                for (int item2 = item + 1; item2 < array.Length; item2++)
                {
                    if (array[item2] < array[minIndex])
                        minIndex = item2;
                }

                temp = array[minIndex];
                array[minIndex] = array[item];
                array[item] = temp;
               
            }
        }
    }
}
