using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Heaps.Tests
{
    [TestClass]
    public class HeapTests
    {
        [TestMethod]
        public void BuildMaxHeap()
        {
            var array = new int[] { 15, 8, 65, 1, 52, 24 };
            var expected = new int[] { 65, 52, 24, 1, 8, 15 };

            var heap = new MaxHeap();
            heap.BuildMaxHeap(array);

            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void DeleteRoot()
        {
            var array = new int[] { 15, 8, 65, 1, 52, 24 };
            var expected = new int[] { 52, 15, 24, 1, 8, int.MinValue };

            var heap = new MaxHeap();
            heap.BuildMaxHeap(array);
            heap.Delete(array, 0);

            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void DeleteRootTwice()
        {
            var array = new int[] { 15, 8, 65, 1, 52, 24 };
            var expected = new int[] { 24, 15, 8, 1, int.MinValue, int.MinValue };

            var heap = new MaxHeap();
            heap.BuildMaxHeap(array);
            heap.Delete(array, 0);
            heap.Delete(array, 0);

            CollectionAssert.AreEqual(expected, array);
        }
    }
}
