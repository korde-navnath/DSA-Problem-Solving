using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Collection
{
    internal class Collection_
    {
        static void Main()
        {
           ArrayList arr = new ArrayList();
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);
            Console.WriteLine(arr.Capacity);
            foreach (int item in arr)
            {
                Console.WriteLine(item + " ");
            }
            Hashtable ht = new Hashtable();
            ht.Add("Eid", 1010);
            ht.Add("Ename", "Bhagwat");
            ht.Add("Wife", "Varsha");
            ht.Add("Sname", "Dake");

            foreach (object entry in ht.Keys)
            {
                Console.WriteLine(entry +" : " + ht[entry]);
            }
        }
    }
}
