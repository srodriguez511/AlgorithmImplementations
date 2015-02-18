using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTrees.Tests
{
    [TestClass]
    public class GetNextNodeTest
    {
        [TestMethod]
        public void NextClosestNode_8()
        {
            var node7 = new NodeP { Data = 4 };
            var node8 = new NodeP { Data = 7 };
            var node9 = new NodeP { Data = 13 };

            var node4 = new NodeP { Data = 1 };
            var node5 = new NodeP { Data = 6, Left = node7, Right = node8 };
            var node6 = new NodeP { Data = 14, Left = node9 };

            var node2 = new NodeP { Data = 3, Left = node4, Right = node5 };
            var node3 = new NodeP { Data = 10, Right = node6 };

            var node1 = new NodeP { Data = 8, Left = node2, Right = node3 };

            node2.Parent = node1;
            node3.Parent = node1;

            node4.Parent = node2;
            node5.Parent = node2;

            node6.Parent = node3;

            node7.Parent = node5;
            node8.Parent = node5;

            node9.Parent = node6;

            var res = GetNextNode.GetNext(node1);
            var exp = node3;

            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void NextClosestNode_3()
        {
            var node7 = new NodeP { Data = 4 };
            var node8 = new NodeP { Data = 7 };
            var node9 = new NodeP { Data = 13 };

            var node4 = new NodeP { Data = 1 };
            var node5 = new NodeP { Data = 6, Left = node7, Right = node8 };
            var node6 = new NodeP { Data = 14, Left = node9 };

            var node2 = new NodeP { Data = 3, Left = node4, Right = node5 };
            var node3 = new NodeP { Data = 10, Right = node6 };

            var node1 = new NodeP { Data = 8, Left = node2, Right = node3 };

            node2.Parent = node1;
            node3.Parent = node1;

            node4.Parent = node2;
            node5.Parent = node2;

            node6.Parent = node3;

            node7.Parent = node5;
            node8.Parent = node5;

            node9.Parent = node6;

            var res = GetNextNode.GetNext(node7);
            var exp = node5;

            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void NextClosestNode_7()
        {
            var node7 = new NodeP { Data = 4 };
            var node8 = new NodeP { Data = 7 };
            var node9 = new NodeP { Data = 13 };

            var node4 = new NodeP { Data = 1 };
            var node5 = new NodeP { Data = 6, Left = node7, Right = node8 };
            var node6 = new NodeP { Data = 14, Left = node9 };

            var node2 = new NodeP { Data = 3, Left = node4, Right = node5 };
            var node3 = new NodeP { Data = 10, Right = node6 };

            var node1 = new NodeP { Data = 8, Left = node2, Right = node3 };

            node2.Parent = node1;
            node3.Parent = node1;

            node4.Parent = node2;
            node5.Parent = node2;

            node6.Parent = node3;

            node7.Parent = node5;
            node8.Parent = node5;

            node9.Parent = node6;

            var res = GetNextNode.GetNext(node8);
            var exp = node1;

            Assert.AreEqual(exp, res);
        }
    }
}
