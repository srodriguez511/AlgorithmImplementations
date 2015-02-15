using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace Strings.Tests
{
    [TestClass]
    public class Permutations
    {
        [TestMethod]
        public void PrintPermutations_Empty()
        {
            var res = AllPermutationsOfString.PrintPermutations("");
            var exp = Enumerable.Empty<string>().ToList();

            CollectionAssert.AreEqual(exp, res);
        }

        [TestMethod]
        public void PrintPermutations_Single()
        {
            var res = AllPermutationsOfString.PrintPermutations("A");
            var exp = new List<string> { "A" };

            CollectionAssert.AreEqual(exp, res);
        }

        [TestMethod]
        public void PrintPermutations_Two()
        {
            var res = AllPermutationsOfString.PrintPermutations("AB");
            var exp = new List<string> { "AB", "BA" };

            CollectionAssert.AreEqual(exp.OrderBy(x => x).ToList(), res.OrderBy(x => x).ToList());
        }

        [TestMethod]
        public void PrintPermutations_Three()
        {
            var res = AllPermutationsOfString.PrintPermutations("ABC");
            var exp = new List<string> { "ABC", "ACB", "CAB", "CBA", "BAC", "BCA" };

            CollectionAssert.AreEqual(exp.OrderBy(x => x).ToList(), res.OrderBy(x => x).ToList());
        }
    }
}
