using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class QuickSort
    {
        // Fixed typo in 'static' and 'Main'
        public static void Main(string[] args)
        {
            List<int> arr = new List<int> { 4, 6, 2, 5, 7, 9, 1, 3 };
            Qs(arr, 0, arr.Count - 1);

            Console.WriteLine(string.Join(", ", arr));
        }

        // Added missing Qs method
        private static void Qs(List<int> arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                Qs(arr, low, pi - 1);
                Qs(arr, pi + 1, high);
            }
        }

        private static int Partition(List<int> arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;
            return i + 1;
        }
    }
}
