using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter
{
    public class Animal : Node
    {
        public Node MyAnimal { get; set; }
        public string Name { get; set; }
    }
}
