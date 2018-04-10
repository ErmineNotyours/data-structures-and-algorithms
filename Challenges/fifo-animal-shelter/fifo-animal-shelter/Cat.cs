using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter
{
    public class Cat : Animal
    {
        public new string Name { get; set; }
        public new Node Next { get; set; }

    }
}
