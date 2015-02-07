using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    public class BinaryTreeNode<T>
    {
        public T Data { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }
    }
    
    public class BinaryTree<T> where T : IComparable
    {
        private BinaryTreeNode<T> _root;

        public BinaryTree()
        {
        }

        public BinaryTree(BinaryTreeNode<T> root)
        {
            _root = root;
        }

        //public List<BinaryTreeNode<T>> GetNodes(T value)
        //{
        //}

        /// <summary>
        /// Insert into the next empty based position using BFS
        /// </summary>
        /// <param name="value"></param>
        public void Insert(T value)
        {
            var newNode = new BinaryTreeNode<T> { Data = value };

        }

        //public bool DeleteNode(T value)
        //{
        //}

        //public List<BinaryTreeNode<T>> InOrderTraversal()
        //{
        //}


        //public List<BinaryTreeNode<T>> PostOrderTraversal()
        //{
        //}

        //public IEnumerable<BinaryTreeNode<T>> PreOrderRecursive()
        //{
        //}

        public IEnumerable<BinaryTreeNode<T>> PreOrderIterative()
        {
            if (_root == null)
            {
                return Enumerable.Empty<BinaryTreeNode<T>>();
            }

            var result = new List<BinaryTreeNode<T>>();
            var stack = new Stack<BinaryTreeNode<T>>();
            stack.Push(_root);

            while (stack.Count > 0)
            {
                var item = stack.Pop();
                if (item != null)
                {
                    result.Add(item);
                    stack.Push(item.Right);
                    stack.Push(item.Left);
                }
            }

            return result;
        }

        public IEnumerable<BinaryTreeNode<T>> InOrderIterative()
        {
            if (_root == null)
            {
                return Enumerable.Empty<BinaryTreeNode<T>>();
            }

            var result = new List<BinaryTreeNode<T>>();
            var stack = new Stack<BinaryTreeNode<T>>();
            var current = _root;

            while (current != null || stack.Count > 0)
            {
                if (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }
                else if (stack.Count > 0)
                {
                    current = stack.Pop();
                    result.Add(current);
                    current = current.Right;
                }
            }

            return result;
        }

        public IEnumerable<BinaryTreeNode<T>> PostOrderIterative()
        {
            if (_root == null)
            {
                return Enumerable.Empty<BinaryTreeNode<T>>();
            }

            var result = new List<BinaryTreeNode<T>>();
            var stack = new Stack<BinaryTreeNode<T>>();
            BinaryTreeNode<T> previous = null;

            stack.Push(_root);

            while (stack.Count > 0)
            {
                var temp = stack.Peek();
                /* case 1. We are nmoving down the tree. */
                if(previous == null || previous.Left == temp || previous.Right == temp){
                    if (temp.Left != null)
                    {
                        stack.Push(temp.Left);
                    }
                    else if (temp.Right != null)
                    {
                        stack.Push(temp.Right);
                    }
                    else
                    {
                        /* If node is leaf node */
                        result.Add(temp);
                        stack.Pop();
                    }
                 }
                 /* case 2. We are moving up the tree from left child */
                if (temp.Left == previous)
                {
                    if (temp.Right != null)
                    {
                        stack.Push(temp.Right);
                    }
                    else
                    {
                        result.Add(temp);
                        stack.Pop();
                    }
                 }
 
                /* case 3. We are moving up the tree from right child */
                if (temp.Right == previous)
                {
                    result.Add(temp);
                    stack.Pop();
                 }
                 previous = temp;
            }

            return result;
        }

        public IEnumerable<BinaryTreeNode<T>> BFSTraversalIterative()
        {
            if (_root == null)
            {
                return Enumerable.Empty<BinaryTreeNode<T>>();
            }

            var result = new List<BinaryTreeNode<T>>();
            var queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(_root);

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                if (item != null)
                {
                    result.Add(item);
                    queue.Enqueue(item.Left);
                    queue.Enqueue(item.Right);
                }
            }

            return result;
        }
    }
}
