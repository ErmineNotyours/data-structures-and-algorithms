using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstTraversal
{
    public class Node
    {
        public int Value { get; set; } // The information from the tree.
        //public Node TreeNode { get; set; } // Nodes pulled from the tree and put into the queue
        public Node LeftChild { get; set; } // Part by the tree only
        public Node RightChild { get; set; } // Part of the tree only
        public Node Next { get; set; } // Accessed by the queue only

    }
}
