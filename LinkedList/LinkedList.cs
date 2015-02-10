using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListNode<T>
    {
        public T Data { get; set; }
        public LinkedListNode<T> Next { get; set; }
    }

    public class LinkedList<T> : IEnumerable<T> where T : IComparable
    {
        private LinkedListNode<T> _head;
        public int Count { get; private set; }

        public LinkedList()
        {
        }

        public void InsertAtHead(T value)
        {
            var node = new LinkedListNode<T> { Data = value };

            if (_head == null)
            {
                _head = node;
            }
            else
            {
                node.Next = _head;
                _head = node;
            }

            Count++;
        }

        public void InsertAtEnd(T value)
        {
            var node = new LinkedListNode<T> { Data = value };

            if (_head == null)
            {
                _head = node;
            }
            else
            {
                var current = _head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = node;
            }

            Count++;
        }

        public void DeleteFirst()
        {
            if (_head != null)
            {
                _head = _head.Next;
                Count--;
            }
        }

        public void DeleteLast()
        {
	        if(_head != null)
	        {
                //Single Item
                if (_head.Next == null)
                {
                    _head = null;
                }
                else
                {
                    var current = _head.Next;

                    while (current.Next.Next != null)
                    {
                        current = current.Next;
                    }

                    current.Next = null;
                }

                Count--;
	        }
        }

        public void DeleteAnyRecursive(T value)
        {
            _head = DeleteAnyRecursive(_head, value);
        }

        private LinkedListNode<T> DeleteAnyRecursive(LinkedListNode<T> node, T value)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Data.Equals(value))
            {
                Count--;
                return node.Next;
            }

            node.Next = DeleteAnyRecursive(node.Next, value);
            return node;
        }

        public void Reverse()
        {
            _head = Reverse(_head);
        }

        private LinkedListNode<T> Reverse(LinkedListNode<T> node)
        {
            if (node == null || node.Next == null)
            {
                return node;
            }

            var last = Reverse(node.Next);
            node.Next.Next = node;
            node.Next = null;

            return last;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = _head;
            while (node != null)
            {
                yield return node.Data;
                node = node.Next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
