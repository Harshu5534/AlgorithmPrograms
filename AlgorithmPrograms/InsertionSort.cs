using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class InsertionSort
    {
        public void Insertion()
        {
            int[] a = new int[6] { 4, 5, 6, 1, 3, 8 };
            int cnt = a.Length;
            int key;
            for(int i = 0; i < cnt; i++)
            {
                key= a[i];
                int j = i - 1;
                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j = j - 1;
                }
                a[j + 1] = key;
            }
            Console.WriteLine("After Sorted Array: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ",a[i]);
            }
        }
    }
}
