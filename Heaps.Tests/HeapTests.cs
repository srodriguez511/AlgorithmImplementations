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
    }
}
