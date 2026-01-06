using System;
using System.Collections.Generic;

namespace Collection
{
    internal class MergeSort
    {
        public static void Merge(List<int> arr, int low, int mid, int high)
        {
            List<int> temp = new List<int>(); // Initialize the list
            int left = low;
            int right = mid + 1;
            
            while(left <= mid && right <= high)
            {
                if (arr[left] <= arr[right])
                {
                    temp.Add(arr[left]);
                    left++;
                }
                else
                {
                    temp.Add(arr[right]);
                    right++;
                }
            }
            
            while(left <= mid)
            {
                temp.Add(arr[left]);
                left++;
            }
            
            while (right <= high) // Fixed: was 'mid', should be 'high'
            {
                temp.Add(arr[right]);
                right++;
            }
            
            for(int i = low; i <= high; i++) // Fixed: was 'i < high', should be 'i <= high'
            {
                arr[i] = temp[i - low];
            }
        }
        
        public static void MS(List<int> arr, int low, int high)
        {
            if (low >= high) return; // Fixed: was 'low == high', should be 'low >= high'
            int mid = (low + high) / 2;
            MS(arr, low, mid);
            MS(arr, mid + 1, high);
            Merge(arr, low, mid, high);
        }
        
        public static void MergeSortArray(List<int> arr, int n)
        {
            MS(arr, 0, n - 1);
        }
        
        // Main method to test the code
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 38, 27, 43, 3, 9, 82, 10 };
            
            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(", ", arr));
            
            MergeSortArray(arr, arr.Count);
            
            Console.WriteLine("\nSorted array:");
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}