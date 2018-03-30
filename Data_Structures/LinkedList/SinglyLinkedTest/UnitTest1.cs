using System;
using Xunit;
using LinkedList;

namespace SinglyLinkedTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2)]
        public void AddTest1(int value)
        {
            Node node1 = new Node();
            SinglyLinked sll = new SinglyLinked(node1); // If this is set later than node1, list starts there
            Assert.Equal(2, sll.Add(value));
        }
        [Theory]
        [InlineData(3)]
        public void AddTest2(int value)
        {
            Node node1 = new Node();
            SinglyLinked sll = new SinglyLinked(node1); // If this is set later than node1, list starts there
            Assert.Equal(3, sll.Add(value));
        }


        [Theory]
        [InlineData(3)]
        public void AddAtEndTest1(int value)
        {
            Node node1 = new Node();
            SinglyLinked sll = new SinglyLinked(node1); // If this is set later than node1, list starts 
            Assert.Equal(3, sll.AddAtEnd(value));
        }
        [Theory]
        [InlineData(5)]
        public void AddAtEndTest2(int value)
        {
            Node node1 = new Node();
            SinglyLinked sll = new SinglyLinked(node1); // If this is set later than node1, list starts 
            Assert.Equal(5, sll.AddAtEnd(value));
        }
        [Theory]
        [InlineData(4)]
        public void AddAtEndTest3(int value)
        {
            Node node1 = new Node();
            SinglyLinked sll = new SinglyLinked(node1); // If this is set later than node1, list starts 
            Assert.Equal(4, sll.AddAtEnd(value));
        }


    }
}
