using System;

namespace Puzzles
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] nums = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
            reverseNumsArray(nums);
        }

        static void reverseNumsArray(int[] arr)
        {
            int total = arr.Length;
            for (int i = 0; i <= total/2-1; i++)
            {
                int hold = arr[i];
                arr[i] = arr[total-i-1];
                arr[total-i-1] = hold;
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
