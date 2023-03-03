using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            Animal cs = new Animal(1, Enums.Type.Carnivore);
            Animal cm = new Animal(3, Enums.Type.Carnivore);
            Animal cl = new Animal(5, Enums.Type.Carnivore);

            Animal hs = new Animal(1, Enums.Type.Herbivore);
            Animal hm = new Animal(3, Enums.Type.Herbivore);
            Animal hl = new Animal(5, Enums.Type.Herbivore);


            Animal[] S1 = { hl, hl, hm, hm, hm, cs };
            Animal[] S2 = { hl, hm, hm, cs, hs, hs, hs, hs, hs };
            Animal[] S3 = { cl, hl, cm, hm, cs, hs };
            Animal[] S4 = { cl, hl, cm, hm, hm, hm, hm, hm, cs, cs, hs };
            Animal[] S5 = { hl, hl, hm, cs, hs };
            Animal[] S6 = { hl, hl, hl, hm, hm, cs, cs, cs };
            Animal[] S7 = { cl, cl, cl, hl, hl, hl, hl, hl, hl, cm, cm, cm, hm, hm, hm, hm, hm, cs, cs, cs, cs, cs, cs, cs, };
            Animal[] S8 = { };

            Train Train = new Train();
            Console.WriteLine("S1:");
            Train.FillCarts(S1);
            Train = new Train();
            Console.WriteLine("S2:");
            Train.FillCarts(S2);
            Train = new Train();
            Console.WriteLine("S3:");
            Train.FillCarts(S3);
            Train = new Train();
            Console.WriteLine("S4:");
            Train.FillCarts(S4);
            Train = new Train();
            Console.WriteLine("S5:");
            Train.FillCarts(S5);
            Train = new Train();
            Console.WriteLine("S6:");
            Train.FillCarts(S6);
            Train = new Train();
            Console.WriteLine("S7:");
            Train.FillCarts(S7);
            Train = new Train();
            Console.WriteLine("S8:");
            Train.FillCarts(S8);
        }
    }
}
