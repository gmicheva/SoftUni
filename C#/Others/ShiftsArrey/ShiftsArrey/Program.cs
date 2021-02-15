using System;

namespace ShiftsArrey
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] { 1, 2, 3, 4, 5 };
            int ellement0 = arr[0];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = ellement0;

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
