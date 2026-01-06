using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Demo
    {
        public static void Main(string[] args)
        {
            int[] arr = { 9, 2, 9, 5, 10 };
            Demo demo = new Demo();
            
            
            Console.WriteLine(demo.PrintArray(arr));

        }



        public int PrintArray(int[] arr)
        {
            int c = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 9)
                    c++;                
            }
            return c;
        }
    }
}
