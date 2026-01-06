using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class LargestElement
    {
        public static int FindLargest(List<int> arr)
        {
            if (arr == null || arr.Count == 0)
                throw new ArgumentException("Array cannot be null or empty");
            int largest = arr[0];
            foreach (int num in arr)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }
            return largest;
        }
        // Main method to test the code
        public static void Main(string[] args)
        {
            List<int> arr = new List<int> { 3, 5, 7, 2, 8, -1 };
            int largestElement = FindLargest(arr);
            Console.WriteLine("The largest element is: " + largestElement);
        }
    }
}
