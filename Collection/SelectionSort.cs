using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class SelectionSort
    {
        public static void Main(string[] args)
        {
            int[] nums = { 13, 46, 24, 52, 20, 9 };
            SelectionSortArray(nums);

            for(int i  = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

        public static int[] SelectionSortArray(int[] nums)
        {
            
            for (int i = 0; i < nums.Length; i++)
            {
                int minimum = i;
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[j] < nums[minimum]) minimum = j;
                }
                int temp = nums[minimum];
                nums[minimum] = nums[i];
                nums[i] = temp;
            }
            return nums;
        }
    }
}
