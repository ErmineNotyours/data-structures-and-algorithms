using System;
using Xunit;
using Stack;


namespace Stack
{
    public class UnitTest1
    {

        [Fact]
        public void CanPeek()
        {
            //Arrange
            Node node = new Node() { Value = 4 };
            Node node2 = new Node() { Value = 8 };
            Node node3 = new Node() { Value = 15 };
            Node node4 = new Node() { Value = 16 };
            Node node5 = new Node() { Value = 23 };
            Node node6 = new Node() { Value = 42 };

            Stack stack = new Stack(node);
            stack.Push(node2);
            stack.Push(node3);
            stack.Push(node4);
            stack.Push(node5);
            stack.Push(node6);

            //Act

            //Assert

            Assert.Equal(42, stack.Peek().Value);
        }


        [Fact]
        public void CanPop()
        {
            //Arrange
            Node node = new Node() { Value = 4 };
            Node node2 = new Node() { Value = 8 };
            Node node3 = new Node() { Value = 15 };
            Node node4 = new Node() { Value = 16 };
            Node node5 = new Node() { Value = 23 };
            Node node6 = new Node() { Value = 42 };

            Stack stack = new Stack(node);
            stack.Push(node2);
            stack.Push(node3);
            stack.Push(node4);
            stack.Push(node5);
            stack.Push(node6);

            //Act

            //Assert

            Assert.Equal(42, stack.Pop().Value);
        }

        [Fact]
        public void CanPopEmpty()
        {
            //Arrange
            Node node = new Node() { Value = 4 };

            Stack stack = new Stack(node);

            //Act

            //Assert

            Assert.Equal(4, stack.Pop().Value);
        }

        [Fact]
        public void CanPopEmpty2()
        {
            //Arrange
            Node node = new Node() { Value = 4 };

            Stack stack = new Stack(node);

            //Act
            Node dummy = stack.Pop();  //Pop completey empty
            //Assert

            Assert.Equal(null, stack.Pop());
        }

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
