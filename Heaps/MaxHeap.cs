using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    public class MaxHeap
    {
        public MaxHeap() { }

        public void BuildMaxHeap(int [] array)
        {
            //Only need to do each parent of a subtree
            for (int i = ((array.Length / 2) - 1); i >= 0; i--)
            {
                MaxHeapify(array, i, array.Length);
            }
        }

        public void MaxHeapify(int [] array, int position, int end)
        {
            var parent = position;
            var left = (2 * position) + 1;
            var right = (2 * position) + 2;
            var largest = position;

            if (left < array.Length  && left < end && array[left] > array[largest])
            {
                largest = left;
            }
            if (right < array.Length && right < end && array[right] > array[largest])
            {
                largest = right;
            }

            if (parent != largest)
            {
                Swap(array, parent, largest);
                MaxHeapify(array, largest, end);
            }
        }

        public void Delete(int[] array, int position)
        {
            //Find the last "empty" position
            var endPosition = array.Length - 1;
            for(int i = array.Length -1; i > 0; i--)
            {
                if(array[i] == int.MinValue)
                {
                    endPosition = i - 1;
                }
                else
                {
                    break;
                }
            }

            Swap(array, position, endPosition);
            array[endPosition] = int.MinValue;

            MaxHeapify(array, 0, endPosition);
        }

        private void Swap(int [] array, int pos1, int pos2)
        {
            var temp = array[pos1];
            array[pos1] = array[pos2];
            array[pos2] = temp;
        }
    }
}
