using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Circustrein
{
    internal class TrainCart
    {
        private List<Animal> Animals = new List<Animal>();
        private const int TotalSpace = 10;

        public bool DoesAnimalFitInCart (Animal Animal)
        {
            int SpaceOccupied = 0;
            bool IsThereACarnivore = false;
            for (int i = 0; i < Animals.Count; i++)
            { 
                SpaceOccupied += Animals[i].Size;
                if (Animals[i].CanEat(Animal) || Animal.CanEat(Animals[i])) { return false; }
            }
            if (SpaceOccupied + Animal.Size > TotalSpace) { return false; }
            return true;
        }

        public void AddAnimalToCart (Animal Animal) => Animals.Add(Animal);

        public int HowFullIsCart () 
        {
            int SpaceOccupied = 0;
            foreach (Animal Animal in Animals) { SpaceOccupied += Animal.Size; }
            return SpaceOccupied;
        }

        public void PrintCartContents ()
        {
            int SpaceOccupied = 0;
            int Carnivores = 0;
            foreach (Animal animal in Animals)
            {
                SpaceOccupied += animal.Size;
                if (animal.Type == Enums.Type.Carnivore) { Carnivores++; }
            }
            Console.WriteLine($"   Total Animals: {Animals.Count} Total Space Occupied: {SpaceOccupied} Total Carnivores: {Carnivores}");
            foreach (Animal animal in Animals)
            {
                Console.WriteLine($"      Size: {animal.Size} Type: {animal.Type}");
            }
            Console.WriteLine();
        }
    }
}
