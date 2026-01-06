using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class InsertionSort
    {
        public static int[] InsertionSortArray(int[] nums,int n) 
        {
            for (int i = 0; i <= n-1; i++)
            {
                int j = i;
                while(j > 0 && nums[j-1] > nums[j])
                {
                    int temp = nums[j-1];
                    nums[j-1] = nums[j];
                    nums[j] = temp;

                    j--;
                }
            }   
            return nums;
        }
        public static void Main(string[] args)
        {
            int[] nums = { 6, 5, 4, 3, 2, 1 };
            int n = nums.Length;
            InsertionSortArray(nums, n);
            for (int i = 0;i < n;i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
