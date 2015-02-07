using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sorting.Tests
{
    [TestClass]
    public class SortingTests
    {
        [TestMethod]
        public void HeapSort()
        {
            var array = new int[] { 15, 8, 65, 1, 52, 24 };
            var expected = new int[] { 1, 8, 15, 24, 52, 65 };
            var heapSort = new HeapSort();
            heapSort.Sort(array);

            CollectionAssert.AreEqual(expected, array);
        }
    }
}
