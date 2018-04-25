using System;
using System.Collections.Generic;
using System.Text;

namespace KeryTree
{
    public class Node
    {
        public Node()
        {
            Children = new List<Node>();
        }
        public string Value { get; set; }
        public List<Node> Children { get; set; }
        // Next required for queue, which is required for breadth-first traversal
        public Node Next { get; set; }
    }
}
