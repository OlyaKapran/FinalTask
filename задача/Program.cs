using System;

namespace задача
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = new string[5] {"Minsk", "hello", "11", "-.", "3"};
            string[] arr2 = new string[arr1.Length];
            int count = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if(arr1[i].Length <= 3)
                {
                    arr2[count] = arr1[i];
                    count++;
                }
            }
            void PrintArray(string[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
            }
            PrintArray(arr2);
        }
    }
}
