using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    public static class GetNextNode
    {
        public static NodeP GetNext(NodeP node)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Right != null)
            {
                return MinNode(node.Right);
            }

            var parent = node.Parent;
            var nodeToCheck = node;

            while (parent != null)
            {
                if (parent.Left == nodeToCheck)
                {
                    return parent;
                }

                nodeToCheck = parent;
                parent = parent.Parent;
            }

            return null;
        }

        public static NodeP MinNode(NodeP node)
        {
            if (node == null || node.Left == null)
            {
                return node;
            }

            return MinNode(node.Left);
        }
    }
}
