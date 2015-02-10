using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace LinkedList.Tests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void InsertAtHead_Empty()
        {
            var ll = new LinkedList<int>();
            ll.InsertAtHead(1);

            var exp = new List<int> { 1 };

            Assert.AreEqual(exp.Count, ll.Count);
            CollectionAssert.AreEqual(exp, ll.ToList());
        }

        [TestMethod]
        public void InsertAtHead_NonEmpty()
        {
            var ll = new LinkedList<int>();
            ll.InsertAtHead(5);
            ll.InsertAtHead(50);
            ll.InsertAtHead(42);

            var exp = new List<int> { 42, 50, 5 };

            Assert.AreEqual(exp.Count, ll.Count);
            CollectionAssert.AreEqual(exp, ll.ToList());
        }

        [TestMethod]
        public void InsertAtEnd_Empty()
        {
            var ll = new LinkedList<int>();
            ll.InsertAtEnd(1);

            var exp = new List<int> { 1 };

            Assert.AreEqual(exp.Count, ll.Count);
            CollectionAssert.AreEqual(exp, ll.ToList());
        }

        [TestMethod]
        public void InsertAtEnd_NonEmpty()
        {
            var ll = new LinkedList<int>();
            ll.InsertAtEnd(5);
            ll.InsertAtEnd(50);
            ll.InsertAtEnd(42);

            var exp = new List<int> { 5, 50, 42 };

            Assert.AreEqual(exp.Count, ll.Count);
            CollectionAssert.AreEqual(exp, ll.ToList());
        }

        [TestMethod]
        public void DeleteFirst_Empty()
        {
            var ll = new LinkedList<int>();
            ll.DeleteFirst();

            var exp = Enumerable.Empty<int>().ToList();

            Assert.AreEqual(exp.Count, ll.Count);
            CollectionAssert.AreEqual(exp, ll.ToList());
        }

        [TestMethod]
        public void DeleteFirst_Multiple()
        {
            var ll = new LinkedList<int>();
            ll.InsertAtHead(1);
            ll.InsertAtHead(2);
            ll.InsertAtHead(3);

            ll.DeleteFirst();

            var exp = new List<int> { 2, 1 };

            Assert.AreEqual(exp.Count, ll.Count);
            CollectionAssert.AreEqual(exp, ll.ToList());
        }

        [TestMethod]
        public void DeleteFirst_Single()
        {
            var ll = new LinkedList<int>();
            ll.InsertAtHead(1);

            ll.DeleteFirst();

            var exp = Enumerable.Empty<int>().ToList();

            Assert.AreEqual(exp.Count, ll.Count);
            CollectionAssert.AreEqual(exp, ll.ToList());
        }

        [TestMethod]
        public void DeleteLast_Empty()
        {
            var ll = new LinkedList<int>();
            ll.DeleteLast();

            var exp = Enumerable.Empty<int>().ToList();

            Assert.AreEqual(exp.Count, ll.Count);
            CollectionAssert.AreEqual(exp, ll.ToList());
        }

        [TestMethod]
        public void DeleteLast_Single()
        {
            var ll = new LinkedList<int>();
            ll.InsertAtHead(1);

            ll.DeleteLast();

            var exp = Enumerable.Empty<int>().ToList();

            Assert.AreEqual(exp.Count, ll.Count);
            CollectionAssert.AreEqual(exp, ll.ToList());
        }

        [TestMethod]
        public void DeleteLast_Multiple()
        {
            var ll = new LinkedList<int>();
            ll.InsertAtHead(1);
            ll.InsertAtHead(2);
            ll.InsertAtHead(3);
            ll.InsertAtHead(4);
            ll.InsertAtHead(5);

            ll.DeleteLast();

            var exp = new List<int> { 5, 4, 3, 2 };

            Assert.AreEqual(exp.Count, ll.Count);
            CollectionAssert.AreEqual(exp, ll.ToList());
        }

        [TestMethod]
        public void DeleteAnyRecursive_Empty()
        {
            var ll = new LinkedList<int>();
            ll.DeleteAnyRecursive(5);

            var exp = Enumerable.Empty<int>().ToList();

            Assert.AreEqual(exp.Count, ll.Count);
            CollectionAssert.AreEqual(exp, ll.ToList());
        }

        [TestMethod]
        public void DeleteAnyRecursive_Single()
        {
            var ll = new LinkedList<int>();
            ll.InsertAtHead(1);

            ll.DeleteAnyRecursive(1);

            var exp = Enumerable.Empty<int>().ToList();

            Assert.AreEqual(exp.Count, ll.Count);
            CollectionAssert.AreEqual(exp, ll.ToList());
        }

        [TestMethod]
        public void DeleteAnyRecursive_Multiple()
        {
            var ll = new LinkedList<int>();
            ll.InsertAtHead(1);
            ll.InsertAtHead(2);
            ll.InsertAtHead(3);
            ll.InsertAtHead(4);
            ll.InsertAtHead(5);

            ll.DeleteAnyRecursive(1);

            var exp = new List<int> { 5, 4, 3, 2 };

            Assert.AreEqual(exp.Count, ll.Count);
            CollectionAssert.AreEqual(exp, ll.ToList());
        }

        [TestMethod]
        public void Reverse_Multiple()
        {
            var ll = new LinkedList<int>();
            ll.InsertAtHead(1);
            ll.InsertAtHead(2);
            ll.InsertAtHead(3);
            ll.InsertAtHead(4);
            ll.InsertAtHead(5);

            ll.Reverse();

            var exp = new List<int> { 1, 2, 3, 4, 5 };

            Assert.AreEqual(exp.Count, ll.Count);
            CollectionAssert.AreEqual(exp, ll.ToList());
        }
    }
}
