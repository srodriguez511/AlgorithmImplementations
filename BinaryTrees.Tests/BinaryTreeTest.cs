using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BinaryTrees.Tests
{
    [TestClass]
    public class BinaryTreeTest
    {
        [TestMethod]
        public void Test_PostOrder_TraversalIterative_Empty()
        {
            var bt = new BinaryTree<int>();
            var res = bt.PostOrderIterative();
            Assert.IsFalse(res.Any());
        }

        [TestMethod]
        public void Test_PostOrder_TraversalIterative()
        {
            var level5_1 = new BinaryTreeNode<int> { Data = 10 };
            var level5_2 = new BinaryTreeNode<int> { Data = 11 };

            var level4_1 = new BinaryTreeNode<int> { Data = 9, Left = level5_1, Right = level5_2 };

            var level3_1 = new BinaryTreeNode<int> { Data = 7, Left = level4_1 };
            var level3_5 = new BinaryTreeNode<int> { Data = 8 };

            var level2_1 = new BinaryTreeNode<int> { Data = 4, Left = level3_1 };
            var level2_3 = new BinaryTreeNode<int> { Data = 5, Left = level3_5 };
            var level2_4 = new BinaryTreeNode<int> { Data = 6 };

            var level1_1 = new BinaryTreeNode<int> { Data = 2, Left = level2_1 };
            var level1_2 = new BinaryTreeNode<int> { Data = 3, Left = level2_3, Right = level2_4 };

            var root = new BinaryTreeNode<int> { Data = 1, Left = level1_1, Right = level1_2 };

            var bt = new BinaryTree<int>(root);
            var res = bt.PostOrderIterative();

            var expected = new List<BinaryTreeNode<int>> { level5_1, level5_2, level4_1, level3_1, level2_1, level1_1, level3_5, level2_3, level2_4, level1_2, root };
            CollectionAssert.AreEqual(expected, res.ToList());
        }


        [TestMethod]
        public void Test_InOrder_TraversalIterative_Empty()
        {
            var bt = new BinaryTree<int>();
            var res = bt.InOrderIterative();
            Assert.IsFalse(res.Any());
        }

        [TestMethod]
        public void Test_InOrder_TraversalIterative()
        {
            var level5_1 = new BinaryTreeNode<int> { Data = 10 };
            var level5_2 = new BinaryTreeNode<int> { Data = 11 };

            var level4_1 = new BinaryTreeNode<int> { Data = 9, Left = level5_1, Right = level5_2 };

            var level3_1 = new BinaryTreeNode<int> { Data = 7, Left = level4_1 };
            var level3_5 = new BinaryTreeNode<int> { Data = 8 };

            var level2_1 = new BinaryTreeNode<int> { Data = 4, Left = level3_1 };
            var level2_3 = new BinaryTreeNode<int> { Data = 5, Left = level3_5 };
            var level2_4 = new BinaryTreeNode<int> { Data = 6 };

            var level1_1 = new BinaryTreeNode<int> { Data = 2, Left = level2_1 };
            var level1_2 = new BinaryTreeNode<int> { Data = 3, Left = level2_3, Right = level2_4 };

            var root = new BinaryTreeNode<int> { Data = 1, Left = level1_1, Right = level1_2 };

            var bt = new BinaryTree<int>(root);
            var res = bt.InOrderIterative();

            var expected = new List<BinaryTreeNode<int>> { level5_1, level4_1, level5_2, level3_1, level2_1, level1_1, root, level3_5, level2_3, level1_2, level2_4};
            CollectionAssert.AreEqual(expected, res.ToList());
        }

        [TestMethod]
        public void Test_PreOrder_TraversalIterative_Empty()
        {
            var bt = new BinaryTree<int>();
            var res = bt.PreOrderIterative();
            Assert.IsFalse(res.Any());
        }

        [TestMethod]
        public void Test_PreOrder_TraversalIterative()
        {
            var level5_1 = new BinaryTreeNode<int> { Data = 10 };
            var level5_2 = new BinaryTreeNode<int> { Data = 11 };

            var level4_1 = new BinaryTreeNode<int> { Data = 9, Left = level5_1, Right = level5_2 };

            var level3_1 = new BinaryTreeNode<int> { Data = 7, Left = level4_1 };
            var level3_5 = new BinaryTreeNode<int> { Data = 8 };

            var level2_1 = new BinaryTreeNode<int> { Data = 4, Left = level3_1 };
            var level2_3 = new BinaryTreeNode<int> { Data = 5, Left = level3_5 };
            var level2_4 = new BinaryTreeNode<int> { Data = 6 };

            var level1_1 = new BinaryTreeNode<int> { Data = 2, Left = level2_1 };
            var level1_2 = new BinaryTreeNode<int> { Data = 3, Left = level2_3, Right = level2_4 };

            var root = new BinaryTreeNode<int> { Data = 1, Left = level1_1, Right = level1_2 };

            var bt = new BinaryTree<int>(root);
            var res = bt.PreOrderIterative();

            var expected = new List<BinaryTreeNode<int>> { root, level1_1, level2_1, level3_1, level4_1, level5_1, level5_2, level1_2, level2_3, level3_5, level2_4 };
            CollectionAssert.AreEqual(expected, res.ToList());
        }

        [TestMethod]
        public void Test_BFSTraversalIterative_Empty()
        {
            var bt = new BinaryTree<int>();
            var res = bt.BFSTraversalIterative();
            Assert.IsFalse(res.Any());
        }

        [TestMethod]
        public void Test_BFSTraversalIterative()
        {
            var level3_2 = new BinaryTreeNode<int> { Data = 6 };

            var level2_1 = new BinaryTreeNode<int> { Data = 4, Right = level3_2 };
            var level2_3 = new BinaryTreeNode<int> { Data = 5 };

            var level1_1 = new BinaryTreeNode<int> { Data = 2, Left = level2_1 };
            var level1_2 = new BinaryTreeNode<int> { Data = 3, Left = level2_3 };
            var root = new BinaryTreeNode<int> { Data = 1, Left = level1_1, Right = level1_2 };

            var bt = new BinaryTree<int>(root);
            var res = bt.BFSTraversalIterative();

            var expected = new List<BinaryTreeNode<int>> { root, level1_1, level1_2, level2_1, level2_3, level3_2 };
            CollectionAssert.AreEqual(expected, res.ToList());
        }
    }
}
