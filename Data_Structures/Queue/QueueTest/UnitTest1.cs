using System;
using Xunit;
using Queue;

namespace QueueTest
{
    public class UnitTest1
    {


        [Fact]
        public void CanDequeue()
        {
            //Arrange
            Node node = new Node() { Value = 4 };
            Node node2 = new Node() { Value = 8 };
            Node node3 = new Node() { Value = 15 };
            Node node4 = new Node() { Value = 16 };
            Node node5 = new Node() { Value = 23 };
            Node node6 = new Node() { Value = 42 };

            MyQueue queue = new MyQueue(node);
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            queue.Enqueue(node4);
            queue.Enqueue(node5);
            queue.Enqueue(node6);

            //Act

            //Assert
            // 4 is the first item entered, so it should be the one Enqueued
            Assert.Equal(4, actual: queue.Dequeue().Value);
        }

        [Fact]
        public void CanDequeueEmpty()
        {
            //Arrange
            Node node = new Node() { Value = 4 };

            MyQueue queue = new MyQueue(node);

            //Act

            //Assert

            Assert.Equal(4, queue.Dequeue().Value);
        }

        [Fact]
        public void CanDequeueEmpty2()
        {
            //Arrange
            Node node = new Node() { Value = 4 };

            MyQueue queue = new MyQueue(node);

            //Act
            Node dummy = queue.Dequeue();  //Pop completely empty
                                           //Assert

            Assert.Equal(null, queue.Dequeue().Next);

        }
    }
}
