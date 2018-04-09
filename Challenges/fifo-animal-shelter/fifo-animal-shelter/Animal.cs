using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter
{
    // This base class is completely sulfurous.  I was trying to have Dog and Cat inherit from this, but I had to inherit directly from Node instead.
    public class Animal : Node
    {
        public Node MyAnimal { get; set; }
    }
}
