using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmPrograms
{
    public class BinarySearch
    {
        public int Binary(string[] array, int firstElement, int lastElement, string key)
        {
            while (lastElement >= firstElement)
            {
                int mid = firstElement + (lastElement - firstElement) / 2;
                int res = key.CompareTo(array[mid]);
                if (res == 0) // Check if key is present at mid
                    return mid;
                if (res > 0) // If key greater, ignore left half
                {
                    firstElement = mid + 1;
                }
                // If key is smaller, ignore right half
                if (res < 0)
                {
                    lastElement = mid - 1;
                }
            }
            return -1;
        }
    }
}
