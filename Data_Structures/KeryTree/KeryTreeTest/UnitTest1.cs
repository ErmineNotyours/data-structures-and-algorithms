using KeryTree;
using System;
using Xunit;

namespace KeryTreeTest
{
    public class UnitTest1
    {
        [Fact]
        public void TreeTest1()
        {
            // Arrange
            Node node = new Node();

            // Declare and populate the nodes
            Node nodeA = new Node() { Value = "A" };
            Node nodeB = new Node() { Value = "B" };
            Node nodeC = new Node() { Value = "C" };
            Node nodeD = new Node() { Value = "D" };
            Node nodeE = new Node() { Value = "E" };
            Node nodeF = new Node() { Value = "F" };
            Node nodeG = new Node() { Value = "G" };
            Node nodeH = new Node() { Value = "H" };
            Node nodeI = new Node() { Value = "I" };
            Node nodeJ = new Node() { Value = "J" };
            Node nodeK = new Node() { Value = "K" };
            Node nodeL = new Node() { Value = "L" };
            Node nodeM = new Node() { Value = "M" };
            Node nodeN = new Node() { Value = "N" };
            Node nodeO = new Node() { Value = "O" };
            Node nodeP = new Node() { Value = "P" };
            Node nodeQ = new Node() { Value = "Q" };


            // Instantiate the tree
            MyTree tree = new MyTree(nodeA);

            // Link the tree.
            nodeA.Children.Add(nodeB);
            nodeA.Children.Add(nodeC);
            nodeA.Children.Add(nodeD);
            nodeA.Children.Add(nodeE);
            nodeA.Children.Add(nodeF);
            nodeA.Children.Add(nodeG);


            nodeB.Children.Add(nodeH);
            nodeB.Children.Add(nodeI);
            nodeB.Children.Add(nodeJ);


            nodeE.Children.Add(nodeK);
            nodeE.Children.Add(nodeL);

            nodeG.Children.Add(nodeM);

            nodeH.Children.Add(nodeN);
            nodeH.Children.Add(nodeO);

            nodeK.Children.Add(nodeP);

            nodeL.Children.Add(nodeQ);

            // Assert
            Assert.Equal("ABCDEFGHIJKLMNOPQ", tree.BreadthFirst(nodeA));

        }

        [Fact]
        public void TreeTest2()
        {
            // Arrange
            Node node = new Node();

            // Declare and populate the nodes
            Node nodeA = new Node() { Value = "A" };
            Node nodeB = new Node() { Value = "B" };
            Node nodeC = new Node() { Value = "C" };

            // Instantiate the tree
            MyTree tree = new MyTree(nodeA);


            // Link the tree
            nodeA.Children.Add(nodeB);
            nodeA.Children.Add(nodeC);

            // Assert
            Assert.Equal("ABC", tree.BreadthFirst(nodeA));
        }

        [Fact]
        public void TreeTest3()
        {
            // Arrange
            Node node = new Node();

            // Declare and populate the node
            Node nodeA = new Node() { Value = "A" };

            // Instantiate the tree
            MyTree tree = new MyTree(nodeA);

            // Assert
            Assert.Equal("A", tree.BreadthFirst(nodeA));
        }

        [Fact]
        public void AddTest1()
        {
            // Arrange
            Node node = new Node();

            // Declare and populate the nodes
            Node nodeA = new Node() { Value = "A" };
            Node nodeB = new Node() { Value = "B" };
            Node nodeC = new Node() { Value = "C" };
            Node nodeD = new Node() { Value = "D" };
            Node nodeE = new Node() { Value = "E" };
            Node nodeF = new Node() { Value = "F" };
            Node nodeG = new Node() { Value = "G" };
            Node nodeH = new Node() { Value = "H" };
            Node nodeI = new Node() { Value = "I" };
            Node nodeJ = new Node() { Value = "J" };
            Node nodeK = new Node() { Value = "K" };
            Node nodeL = new Node() { Value = "L" };
            Node nodeM = new Node() { Value = "M" };
            Node nodeN = new Node() { Value = "N" };
            Node nodeO = new Node() { Value = "O" };
            Node nodeP = new Node() { Value = "P" };
            Node nodeQ = new Node() { Value = "Q" };


            // Instantiate the tree
            MyTree tree = new MyTree(nodeA);

            // Link the tree.
            nodeA.Children.Add(nodeB);
            nodeA.Children.Add(nodeC);
            nodeA.Children.Add(nodeD);
            nodeA.Children.Add(nodeE);
            nodeA.Children.Add(nodeF);
            nodeA.Children.Add(nodeG);


            nodeB.Children.Add(nodeH);
            nodeB.Children.Add(nodeI);
            nodeB.Children.Add(nodeJ);


            nodeE.Children.Add(nodeK);
            nodeE.Children.Add(nodeL);

            nodeG.Children.Add(nodeM);

            nodeH.Children.Add(nodeN);
            nodeH.Children.Add(nodeO);

            nodeK.Children.Add(nodeP);

            nodeL.Children.Add(nodeQ);

            // Act
            tree.AddNode(nodeA, "Z");

            // Assert

            Assert.Equal("ABCDEFGZHIJKLMNOPQ", tree.BreadthFirst(nodeA));
        }

        [Fact]
        public void AddTest2()
        {
            // Arrange
            Node node = new Node();

            // Declare and populate the nodes
            Node nodeA = new Node() { Value = "A" };
            Node nodeB = new Node() { Value = "B" };
            Node nodeC = new Node() { Value = "C" };

            // Instantiate the tree
            MyTree tree = new MyTree(nodeA);


            // Link the tree
            nodeA.Children.Add(nodeB);
            nodeA.Children.Add(nodeC);

            // Act
            tree.AddNode(nodeA, "Z");


            // Assert
            Assert.Equal("ABCZ", tree.BreadthFirst(nodeA));
        }

        [Fact]
        public void AddTest3()
        {
            // Arrange
            Node node = new Node();
            MyTree tree = new MyTree(node);

            // Act

            tree.AddNode(node, "Y");

            // Assert
            Assert.Equal("Y", tree.BreadthFirst(node));
        }

    }

}
