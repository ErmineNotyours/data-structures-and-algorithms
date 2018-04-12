using FindMaximum;
using System;
using Xunit;

namespace FindMaximumTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
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

            Assert.Equal(7, Program.FindMaximumValue(tree, node1));
        }

        [Fact]
        public void Test2()
        {
            //Arrange 
            Node node = new Node();

            // Declare and populate the nodes
            Node node1 = new Node() { Value = -1 };
            Node node2 = new Node() { Value = -2 };
            Node node3 = new Node() { Value = -3 };
            Node node4 = new Node() { Value = -4 };
            Node node5 = new Node() { Value = -5 };
            Node node6 = new Node() { Value = -6 };
            Node node7 = new Node() { Value = -7 };

            // Instantiate the tree
            MyTree tree = new MyTree(node);

            // Link the tree.
            node1.LeftChild = node2;
            node1.RightChild = node3;

            node2.LeftChild = node4;
            node2.RightChild = node5;

            node3.LeftChild = node6;
            node3.RightChild = node7;

            Assert.Equal(-1, Program.FindMaximumValue(tree, node1));
        }

        [Fact]
        public void Test3() // Sample tree from the assignment
        {
            //Arrange 
            Node node = new Node();

            // Declare and populate the nodes
            Node node1 = new Node() { Value = 2 };
            Node node2 = new Node() { Value = 7 };
            Node node3 = new Node() { Value = 5 };
            Node node4 = new Node() { Value = 2 };
            Node node5 = new Node() { Value = 6 };
            Node node6 = new Node() { Value = 9 };
            Node node7 = new Node() { Value = 5 };
            Node node8 = new Node() { Value = 11 };
            Node node9 = new Node() { Value = 4 };

            // Instantiate the tree
            MyTree tree = new MyTree(node);

            // Link the tree.
            node1.LeftChild = node2;
            node1.RightChild = node3;

            node2.LeftChild = node4;
            node2.RightChild = node5;

            node3.RightChild = node6;

            // node4 is a leaf

            node5.LeftChild = node7;
            node5.RightChild = node8;

            node6.LeftChild = node9;

            Assert.Equal(11, Program.FindMaximumValue(tree, node1));
        }

    }
}
