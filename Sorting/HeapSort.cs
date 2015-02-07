using Heaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class HeapSort
    {
        public void Sort(int[] array)
        {
            var heap = new MaxHeap();
            //O(n);
            heap.BuildMaxHeap(array);

            for(int i = 0; i < array.Length; i++){
                Swap(array, 0, array.Length - 1 - i);
                heap.MaxHeapify(array, 0, (array.Length - 1 - i));
            }
        }

        private void Swap(int [] array, int pos1, int pos2)
        {
            var temp = array[pos1];
            array[pos1] = array[pos2];
            array[pos2] = temp;
        }
    }
}
