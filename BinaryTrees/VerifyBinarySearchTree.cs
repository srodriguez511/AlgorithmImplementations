using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    public static class VerifyBinarySearchTree
    {
        public static Node previous;
        public static bool Verify(Node node)
        {     
            // traverse the tree in inorder fashion and keep track of prev node
            if (node != null)
            {
                if (!Verify(node.Left))
                {
                    return false;
                }

                if (previous != null && node.Data <= previous.Data)
                {
                    return false;
                }

                previous = node;
                return Verify(node.Right);
            }
 
            return true;
        }
    }
}
