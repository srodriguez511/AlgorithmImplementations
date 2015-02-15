using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BinaryTrees.Tests
{
    [TestClass]
    public class PrintAllItemsAtLevelTest
    {
        [TestMethod]
        public void PrintAllItems_Success_1()
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

            var exp = new List<int> { 8 };
            var res = PrintAllItemsAtLevel.PrintItems(node1, 1);

            CollectionAssert.AreEqual(exp, res);
        }

        [TestMethod]
        public void PrintAllItems_Success_2()
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

            var exp = new List<int> { 3, 10 };
            var res = PrintAllItemsAtLevel.PrintItems(node1, 2);

            CollectionAssert.AreEqual(exp, res);
        }

        [TestMethod]
        public void PrintAllItems_Success_3()
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

            var exp = new List<int> { 1, 6, 14 };
            var res = PrintAllItemsAtLevel.PrintItems(node1, 3);

            CollectionAssert.AreEqual(exp, res);
        }

        [TestMethod]
        public void PrintAllItems_Success_4()
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

            var exp = new List<int> { 4, 7, 13 };
            var res = PrintAllItemsAtLevel.PrintItems(node1, 4);

            CollectionAssert.AreEqual(exp, res);
        }
    }
}
