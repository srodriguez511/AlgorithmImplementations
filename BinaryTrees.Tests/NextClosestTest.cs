using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTrees.Tests
{
    [TestClass]
    public class NextClosestTest
    {
        [TestMethod]
        public void NextClosestTest_8()
        {
            var node7 = new Node { Data = 4 };
            var node8 = new Node { Data = 7 };
            var node9 = new Node { Data = 13 };

            var node4 = new Node { Data = 1 };
            var node5 = new Node { Data = 6, Left = node7, Right = node8 };
            var node6 = new Node { Data = 14, Left = node9 };

            var node2 = new Node { Data = 3, Left = node4, Right = node5 };
            var node3 = new Node { Data = 10, Right = node6 };

            var node1 = new Node { Data = 8, Left = node2, Right = node3 };

            var res = NextClosest.NextClosestItem(node1, 8, int.MinValue);

            Assert.AreEqual(8, res);
        }

        [TestMethod]
        public void NextClosestTest_11()
        {
            var node7 = new Node { Data = 4 };
            var node8 = new Node { Data = 7 };
            var node9 = new Node { Data = 13 };

            var node4 = new Node { Data = 1 };
            var node5 = new Node { Data = 6, Left = node7, Right = node8 };
            var node6 = new Node { Data = 14, Left = node9 };

            var node2 = new Node { Data = 3, Left = node4, Right = node5 };
            var node3 = new Node { Data = 10, Right = node6 };

            var node1 = new Node { Data = 8, Left = node2, Right = node3 };

            var res = NextClosest.NextClosestItem(node1, 11, int.MinValue);

            Assert.AreEqual(10, res);
        }

        [TestMethod]
        public void NextClosestTest_2()
        {
            var node7 = new Node { Data = 4 };
            var node8 = new Node { Data = 7 };
            var node9 = new Node { Data = 13 };

            var node4 = new Node { Data = 1 };
            var node5 = new Node { Data = 6, Left = node7, Right = node8 };
            var node6 = new Node { Data = 14, Left = node9 };

            var node2 = new Node { Data = 3, Left = node4, Right = node5 };
            var node3 = new Node { Data = 10, Right = node6 };

            var node1 = new Node { Data = 8, Left = node2, Right = node3 };

            var res = NextClosest.NextClosestItem(node1, 2, int.MinValue);

            Assert.AreEqual(3, res);
        }
    }
}
