using System;
using Xunit;
using FizzBuzz;

namespace FizzBuzzTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            Node node = new Node();

            // Declare and populate the nodes
            Node node1 = new Node() { Value = 1.ToString() };
            Node node2 = new Node() { Value = 3.ToString() };
            Node node3 = new Node() { Value = 5.ToString() };
            Node node4 = new Node() { Value = 16.ToString() };
            Node node5 = new Node() { Value = 21.ToString() };
            Node node6 = new Node() { Value = 30.ToString() };
            Node node7 = new Node() { Value = 45.ToString() };

            // Instantiate the tree
            MyTree tree = new MyTree(node);

            // Link the tree.
            node1.LeftChild = node2;
            node1.RightChild = node3;

            node2.LeftChild = node4;
            node2.RightChild = node5;

            node3.LeftChild = node6;
            node3.RightChild = node7;

            Assert.Equal(" 16 Fizz 16 Fizz Fizz 1 16 Fizz 16 Fizz Fizz 1 16 Fizz 16 Fizz Fizz 1 FizzBuzz Buzz 16 Fizz 16 Fizz Fizz 1 16 Fizz 16 Fizz Fizz 1 FizzBuzz Buzz FizzBuzz", MyTree.FizzBuzz(node1, ""));
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            Node node = new Node();

            // Declare and populate the nodes
            Node node1 = new Node() { Value = 1.ToString() };
            Node node2 = new Node() { Value = 3.ToString() };
            Node node3 = new Node() { Value = 5.ToString() };

            // Instantiate the tree
            MyTree tree = new MyTree(node);

            // Link the tree.
            node1.LeftChild = node2;
            node1.RightChild = node3;

            Assert.Equal(" Fizz 1 Fizz 1 Buzz", MyTree.FizzBuzz(node1, ""));
        }
        
        [Fact]
        public void Test3()
        {
            // Arrange
            Node node = new Node();

            // Instantiate a blank tree
            MyTree tree = new MyTree(node);

            Assert.Equal("", MyTree.FizzBuzz(node, ""));

        }
    }
}
