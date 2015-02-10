using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Tests
{
    [TestClass]
    public class OcurranceOfNumberSortedArray
    {
        [TestMethod]
        public void FindOcurrance_Empty()
        {
            var array = new int[] { };
            var expected = 0;

            var res = OccurranceOfNumberSortedArray.FindOcurrance(array, 0, array.Length - 1, 1);
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void FindOcurrance_NotFound()
        {
            var array = new int[] { 1, 2, 3, 4, 5 };
            var expected = 0;

            var res = OccurranceOfNumberSortedArray.FindOcurrance(array, 0, array.Length - 1, 100);
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void FindOcurrance_FoundOnce()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var expected = 1;

            var res = OccurranceOfNumberSortedArray.FindOcurrance(array, 0, array.Length - 1, 11);
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void FindOcurrance_FoundMultiple()
        {
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 10, 11 };
            var expected = 4;

            var res = OccurranceOfNumberSortedArray.FindOcurrance(array, 0, array.Length - 1, 9);
            Assert.AreEqual(expected, res);
        }
    }
}
