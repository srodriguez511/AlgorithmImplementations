using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    public static class PrintAllItemsAtLevel
    {
        public static List<int> PrintItems(Node root, int level)
        {
            if (root == null || level <= 0)
            {
                return Enumerable.Empty<int>().ToList();
            }

            var numItems = Math.Pow(2, (level - 1));
            var start = numItems;
            var endIndex = (numItems + numItems) - 1;
            var currentIndex = 1;
            var queue = new Queue<Node>();
            var res = new List<int>();
            queue.Enqueue(root);

            while (currentIndex <= endIndex && queue.Count > 0)
            {
                var currItem = queue.Dequeue();
                if (currItem != null)
                {
                    if (currentIndex >= start)
                    {
                        res.Add(currItem.Data);
                    }

                    queue.Enqueue(currItem.Left);
                    queue.Enqueue(currItem.Right);
                }
                else
                {
                    queue.Enqueue(null);
                    queue.Enqueue(null);
                }

                currentIndex++;
            }

            return res;
        }
    }
}
