using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Animal
    {
        public int Size { get; private set; }
        public Enums.Type Type { get; private set; }

        public Animal(int Size, Enums.Type Type)
        {
            this.Size = Size;
            this.Type = Type;
        }

        public bool CanEat(Animal Animal)
        {
            if (this.Type == Enums.Type.Carnivore && this.Size >= Animal.Size) { return true; } 
            return false;
        }
    }
}
