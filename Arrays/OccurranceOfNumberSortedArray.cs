using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class OccurranceOfNumberSortedArray
    {
        public static int FindOcurrance(int[] array, int start, int end, int num)
        {
            if (start > end)
            {
                return 0;
            }

            var mid = (start + end) / 2;

            if (array[mid] == num)
            {
                return 1 + FindOcurrance(array, start, mid - 1, num) + FindOcurrance(array, mid + 1, end, num);
                //var occurrances = 0;

                //for (int i = mid; i >= start; i--)
                //{
                //    if (array[i] != num)
                //    {
                //        break;
                //    }

                //    occurrances++;
                //}

                //for(int i = mid + 1; i <= end; i++)
                //{
                //    if (array[i] != num)
                //    {
                //        break;
                //    }

                //    occurrances++;
                //}

                //return occurrances;
            }
            else
            {
                if (num > array[mid])
                {
                    return FindOcurrance(array, mid + 1, end, num);
                }
                else
                {
                    return FindOcurrance(array, start, mid - 1, num);
                }
            }
        }
    }
}
