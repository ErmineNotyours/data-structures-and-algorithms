using System;
using System.Collections.Generic;
using System.Text;

namespace PrintLevelOrder
{
    public class Node
    {
        public Node()
        {
            Children = new List<Node>();
        }
        public string Value { get; set; }
        public List<Node> Children { get; set; }
    }
}
