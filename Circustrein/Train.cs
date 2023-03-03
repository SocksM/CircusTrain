using Circustrein;
using System.Runtime.CompilerServices;

namespace Circustrein
{
    public class Train
    {
        // this method assumes the list is sorted as follows:
        // 1. Biggest Animal -> Smallest Animal
        // 2. Carnivore -> Herbivore
        public int FillCarts(Animal[] AnimalsArray)
        {
            List<Animal> Animals = AnimalsArray.ToList();
            List<TrainCart> TrainCarts = new List<TrainCart>();
            while (Animals.Count > 0)
            {
                TrainCarts.Add(new TrainCart());
                for (int i = 0; i < TrainCarts.Count; i++)
                {
                    for (int j = 0; j < Animals.Count; j++)
                    {
                        if (TrainCarts[i].DoesAnimalFitInCart(Animals[j]))
                        {
                            TrainCarts[i].AddAnimalToCart(Animals[j]);
                            Animals.Remove(Animals[j]);
                            j--;
                        }
                    }
                }

            }
            for (int i = 0; i < TrainCarts.Count; i++)
            {
                Console.WriteLine($"Cart {i}:");
                TrainCarts[i].PrintCartContents();
            }
            return TrainCarts.Count;
        }

        

        public Animal[] SortAnimalList(Animal[] Animals)
        {

            return Animals;
        }
    }
}

