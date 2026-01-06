using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class BubbleSort
    {
        public static int[] BubbleSortArray(int[] nums, int n) 
        {
            for(int i = n-1;  i >= 1; i--)
            {
                int didSwap = 0;
                for (int j = 0; j <= i-1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j+1];
                        nums[j+1] = nums[j];
                        nums[j] = temp;
                        didSwap = 1;
                    }
                }
                if(didSwap == 0)
                {
                    break;
                }
            }
            return nums;
        }

        public static void Main(string[] args) 
        {
            int[] nums = { 13, 46, 24, 52, 20, 9 };
            int n = nums.Length;
            BubbleSortArray(nums , n);

            foreach(int i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}
