using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class FindMissingElement
    {
        public static int FindMissing(int[] arr, int n)
        {
            int total =  n * (n + 1) / 2; 
            int sum = 0;
            for (int i = 0; i < n-1; i++)
            {
                sum += arr[i];
            }
            return total - sum; 
        }
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 5, 6 };
            int n = arr.Length + 1;
            int missingElement = FindMissing(arr, n);
            Console.WriteLine("The missing element is: " + missingElement);
        }
    }
}
