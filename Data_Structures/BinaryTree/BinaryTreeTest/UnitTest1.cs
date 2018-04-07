using System;
using Xunit;

namespace BinaryTree
{
    public class UnitTest1
    {
        [Fact]
        public void InOrder1()
        {
            //Arrange 
            Node node = new Node();

            // Declare and populate the nodes
            Node node1 = new Node() { Value = 1 };
            Node node2 = new Node() { Value = 2 };
            Node node3 = new Node() { Value = 3 };
            Node node4 = new Node() { Value = 4 };
            Node node5 = new Node() { Value = 5 };
            Node node6 = new Node() { Value = 6 };
            Node node7 = new Node() { Value = 7 };

            // Instantiate the tree
            MyTree tree = new MyTree(node);

            // Link the tree.
            node1.LeftChild = node2;
            node1.RightChild = node3;

            node2.LeftChild = node4;
            node2.RightChild = node5;

            node3.LeftChild = node6;
            node3.RightChild = node7;

            Assert.Equal(" 4 2 4 2 5 1 4 2 4 2 5 1 4 2 4 2 5 1 6 3 4 2 4 2 5 1 4 2 4 2 5 1 6 3 7", MyTree.InOrder(node1, ""));


        }

        [Fact]
        public void InOrder2()
        {
            //Arrange 
            Node node = new Node();

            // Declare and populate the nodes
            Node node1 = new Node() { Value = 1 };

            // Instantiate the tree
            MyTree tree = new MyTree(node);

            Assert.Equal(" 1", MyTree.InOrder(node1, ""));
        }

        [Fact]
        public void InOrder3()
        {
            //Arrange 
            Node node = new Node();

            // Declare and populate the nodes
            Node node1 = new Node() { Value = 1 };
            Node node2 = new Node() { Value = 2 };
            Node node3 = new Node() { Value = 3 };

            // Instantiate the tree
            MyTree tree = new MyTree(node);

            // Link the tree
            node1.LeftChild = node2;
            node1.RightChild = node3;

            Assert.Equal(" 2 1 2 1 3", MyTree.InOrder(node1, ""));

        }

        [Fact]
        public void PreOrder1()
        {
            //Arrange 
            Node node = new Node();

            // Declare and populate the nodes
            Node node1 = new Node() { Value = 1 };
            Node node2 = new Node() { Value = 2 };
            Node node3 = new Node() { Value = 3 };
            Node node4 = new Node() { Value = 4 };
            Node node5 = new Node() { Value = 5 };
            Node node6 = new Node() { Value = 6 };
            Node node7 = new Node() { Value = 7 };

            // Instantiate the tree
            MyTree tree = new MyTree(node);

            // Link the tree.
            node1.LeftChild = node2;
            node1.RightChild = node3;

            node2.LeftChild = node4;
            node2.RightChild = node5;

            node3.LeftChild = node6;
            node3.RightChild = node7;


            Assert.Equal(" 1 1 2 1 2 4 1 2 1 2 4 5 1 1 2 1 2 4 1 2 1 2 4 5 3 1 1 2 1 2 4 1 2 1 2 4 5 3 6 1 1 2 1 2 4 1 2 1 2 4 5 3 1 1 2 1 2 4 1 2 1 2 4 5 3 6 7", MyTree.PreOrder(node1, ""));
        }

        [Fact]
        public void PreOrder2()
        {
            //Arrange 
            Node node = new Node();

            // Declare and populate the nodes
            Node node1 = new Node() { Value = 1 };

            // Instantiate the tree
            MyTree tree = new MyTree(node);

            Assert.Equal(" 1", MyTree.PreOrder(node1, ""));
        }

        [Fact]
        public void PreOrder3()
        {
            //Arrange 
            Node node = new Node();

            // Declare and populate the nodes
            Node node1 = new Node() { Value = 1 };
            Node node2 = new Node() { Value = 2 };
            Node node3 = new Node() { Value = 3 };

            // Instantiate the tree
            MyTree tree = new MyTree(node);

            // Link the tree
            node1.LeftChild = node2;
            node1.RightChild = node3;

            Assert.Equal(" 1 1 2 1 1 2 3", MyTree.PreOrder(node1, ""));
        }

        [Fact]
        public void PostOrder1()
        {
            //Arrange 
            Node node = new Node();

            // Declare and populate the nodes
            Node node1 = new Node() { Value = 1 };
            Node node2 = new Node() { Value = 2 };
            Node node3 = new Node() { Value = 3 };
            Node node4 = new Node() { Value = 4 };
            Node node5 = new Node() { Value = 5 };
            Node node6 = new Node() { Value = 6 };
            Node node7 = new Node() { Value = 7 };

            // Instantiate the tree
            MyTree tree = new MyTree(node);

            // Link the tree.
            node1.LeftChild = node2;
            node1.RightChild = node3;

            node2.LeftChild = node4;
            node2.RightChild = node5;

            node3.LeftChild = node6;
            node3.RightChild = node7;


            Assert.Equal(" 4 4 5 2 4 4 5 2 4 4 5 2 6 4 4 5 2 4 4 5 2 6 7 3 1", MyTree.PostOrder(node1, ""));
        }

        public void PostOrder2()
        {
            //Arrange 
            Node node = new Node();

            // Declare and populate the nodes
            Node node1 = new Node() { Value = 1 };

            // Instantiate the tree
            MyTree tree = new MyTree(node);

            Assert.Equal(" 1", MyTree.PostOrder(node1, ""));
        }
        [Fact]
        public void PostOrder3()
        {
            //Arrange 
            Node node = new Node();

            // Declare and populate the nodes
            Node node1 = new Node() { Value = 1 };
            Node node2 = new Node() { Value = 2 };
            Node node3 = new Node() { Value = 3 };

            // Instantiate the tree
            MyTree tree = new MyTree(node);

            // Link the tree
            node1.LeftChild = node2;
            node1.RightChild = node3;

            Assert.Equal(" 2 2 3 1", MyTree.PostOrder(node1, ""));
        }

    }

}
