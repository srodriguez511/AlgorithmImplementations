using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class MaximumSubArray
    {
        public static int MaximumSubArrayBruteForce(int[] array)
        {
            int final = Int32.MinValue;
            for (int pairSize = 1; pairSize < array.Length; pairSize++)
            {
                for (int position = 0; position < (array.Length - pairSize); position++)
                {
                    int sum = 0;
                    for (int i = position, j = 0; j < pairSize; i++, j++)
                    {
                        sum += array[i];
                    }
                    final = Math.Max(sum, final);
                }
            }

            return final;
        }

        public static int MaximumSubArrayDivideAndConquer(int [] array, int start, int end)
        {
	        if(start == end)
            {
		        return array[start];
	        }
	
	        var mid = (start + end) / 2;
	        var leftMax = MaximumSubArrayDivideAndConquer(array, start, mid);
	        var rightMax = MaximumSubArrayDivideAndConquer(array, mid + 1, end);
	        var crossMiddleMax = FindCrossMax(array, start, mid, end);
	
	        return Math.Max(Math.Max(leftMax, rightMax), crossMiddleMax);
        }

        private static int FindCrossMax(int [] array, int start, int mid, int end){
            var maxLeftCrossSum = Int32.MinValue;
            var maxRightCrossSum = Int32.MinValue;
	
            var sum = 0;
	        for(int i = mid; i >= start; i--)
            {
		        sum += array[i];
		        maxLeftCrossSum = Math.Max(sum, maxLeftCrossSum);
	        }

            sum = 0;
	        for(int i = mid + 1; i <= end; i++){
		        sum += array[i];
		        maxRightCrossSum = Math.Max(sum, maxRightCrossSum);
	        }
	
	        return maxLeftCrossSum + maxRightCrossSum;
        }

        public static int MaximumSubArrayKadane(int[] array)
        {
            if(array.Length == 1)
            {
                return array[0];
            }

            var sum = int.MinValue;
            var maxSum = int.MinValue;
            var maxNeg = int.MinValue;
            var allNeg = true;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 && allNeg)
                {
                    maxNeg = Math.Max(maxNeg, array[i]);
                }
                else
                {
                    allNeg = false;
                }

                sum += array[i];
                if (sum < 0)
                {
                    sum = 0;
                }
                else
                {
                    maxSum = Math.Max(maxSum, sum);
                }
            }

            if (allNeg)
            {
                return maxNeg;
            }
            return maxSum;
        }
    }
}
