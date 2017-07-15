using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMedian
{
    class Logic
    {
        public int[] SortArray(int[] unsortedArray)
        {
            Array.Sort(unsortedArray);
            return unsortedArray;
        }

        public int ReturnLength(int[] unsortedArray)
        {
            return unsortedArray.Length; 
        }

        public double FindMedian(int[] array)
        {
            array = SortArray(array);

            if(ReturnLength(array) % 2 != 0 )
            {
                return array[(ReturnLength(array) / 2)];
            }
            else
            {
                var middle1 = ReturnLength(array)/2 - 1;
                var middle2 = ReturnLength(array)/2;

                return (array[middle1] + array[middle2]) / 2.0;
            }
        }
    }
}
