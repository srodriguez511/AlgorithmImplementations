using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arrays.Tests
{
    [TestClass]
    public class MaximumSubArrayTests
    {
        [TestMethod]
        public void MaxiumSubArray_Brute()
        {
            var array = new int[] { 1, -3, 2, -5, 7, 6, -1, -4, 11, -23 };
            var expected = 19;

            var res = MaximumSubArray.MaximumSubArrayBruteForce(array);
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void MaximumSubArray_DivideAndConquer()
        {
            var array = new int[] { 1, -3, 2, -5, 7, 6, -1, -4, 11, -23 };
            var expected = 19;

            var res = MaximumSubArray.MaximumSubArrayDivideAndConquer(array, 0, array.Length - 1);
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void MaximumSubArray_Kadane()
        {
            var array = new int[] { 1, -3, 2, -5, 7, 6, -1, -4, 11, -23 };
            var expected = 19;

            var res = MaximumSubArray.MaximumSubArrayKadane(array);
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void MaximumSubArray_Kadane_AllNegative()
        {
            var array = new int[] { -1, -2, -3, -4, -5 };
            var expected = -1;

            var res = MaximumSubArray.MaximumSubArrayKadane(array);
            Assert.AreEqual(expected, res);
        }


        [TestMethod]
        public void MaximumSubArray_DivideAndConquer_AllNegative()
        {
            var array = new int[] { -1, -2, -3, -4, -5 };
            var expected = -1;

            var res = MaximumSubArray.MaximumSubArrayDivideAndConquer(array, 0, array.Length -1);
            Assert.AreEqual(expected, res);
        }


        [TestMethod]
        public void MaximumSubArray_Brute_AllNegative()
        {
            var array = new int[] { -1, -2, -3, -4, -5 };
            var expected = -1;

            var res = MaximumSubArray.MaximumSubArrayBruteForce(array);
            Assert.AreEqual(expected, res);
        }
    }
}
