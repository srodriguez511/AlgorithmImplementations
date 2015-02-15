using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTrees.Tests
{
    [TestClass]
    public class VerifyBinarySearchTreeTest
    {
        [TestMethod]
        public void VerifyBinarySearchTree_Empty()
        {
            var res = VerifyBinarySearchTree.Verify(null);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void VerifyBinarySearchTree_Single()
        {
            var node = new Node { Data = 1 };

            var res = VerifyBinarySearchTree.Verify(node);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void VerifyBinarySearchTree_Multilple_True()
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

            VerifyBinarySearchTree.previous = null;
            var res = VerifyBinarySearchTree.Verify(node1);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void VerifyBinarySearchTree_Multilple_False()
        {
            var node7 = new Node { Data = 4 };
            var node8 = new Node { Data = 7 };
            var node9 = new Node { Data = 15 }; //Breaks the BST

            var node4 = new Node { Data = 1 };
            var node5 = new Node { Data = 6, Left = node7, Right = node8 };
            var node6 = new Node { Data = 14, Left = node9 };

            var node2 = new Node { Data = 3, Left = node4, Right = node5 };
            var node3 = new Node { Data = 10, Right = node6 };

            var node1 = new Node { Data = 8, Left = node2, Right = node3 };

            VerifyBinarySearchTree.previous = null;
            var res = VerifyBinarySearchTree.Verify(node1);
            Assert.IsFalse(res);
        }
    }
}
