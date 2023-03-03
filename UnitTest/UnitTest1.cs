using System;
using Circustrein;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace UnitTest
{

    public class Tests
    {
        Animal cs = new Animal(1, Enums.Type.Carnivore);
        Animal cm = new Animal(3, Enums.Type.Carnivore);
        Animal cl = new Animal(5, Enums.Type.Carnivore);

        Animal hs = new Animal(1, Enums.Type.Herbivore);
        Animal hm = new Animal(3, Enums.Type.Herbivore);
        Animal hl = new Animal(5, Enums.Type.Herbivore);

        List<Animal> Animals;
        List<Animal>[] Scenarios = new List<Animal>[8];

        [SetUp]
        public void Setup()
        {
            Animals = new List<Animal> { hl, hm, hs, cl, cm, cs };

            // type then size
            Animal[] S1 = { cs, hl, hl, hm, hm, hm };
            Animal[] S2 = { cs, hl, hm, hm, hs, hs, hs, hs, hs };
            Animal[] S3 = { cl, cm, cs, hl, hm, hs };
            Animal[] S4 = { cl, cm, cs, cs, hl, hm, hm, hm, hm, hm, hs };
            Animal[] S5 = { cs, hl, hl, hm, hs };
            Animal[] S6 = { cs, cs, cs, hl, hl, hl, hm, hm };
            Animal[] S7 = { cl, cl, cl, cm, cm, cm, cs, cs, cs, cs, cs, cs, cs, hl, hl, hl, hl, hl, hl, hm, hm, hm, hm, hm };
            Animal[] S8 = { };

            // size then type 
            //Animal[] S1 = { hl, hl, hm, hm, hm, cs };
            //Animal[] S2 = { hl, hm, hm, cs, hs, hs, hs, hs, hs };
            //Animal[] S3 = { cl, hl, cm, hm, cs, hs };
            //Animal[] S4 = { cl, hl, cm, hm, hm, hm, hm, hm, cs, cs, hs };
            //Animal[] S5 = { hl, hl, hm, cs, hs };
            //Animal[] S6 = { hl, hl, hl, hm, hm, cs, cs, cs };
            //Animal[] S7 = { cl, cl, cl, hl, hl, hl, hl, hl, hl, cm, cm, cm, hm, hm, hm, hm, hm, cs, cs, cs, cs, cs, cs, cs };
            //Animal[] S8 = { };

            // inverted size then type 
            //      could work with more verification (?) (further inspection probs not)
            //Animal[] S1 = { cs, hm, hm, hm, hl, hl };
            //Animal[] S2 = { cs, hs, hs, hs, hs, hs, hm, hm, hl };
            //Animal[] S3 = { cs, hs, cm, hm, cl, hl };
            //Animal[] S4 = { cs, cs, cm, hm, hm, hm, hm, hm, hs, cl, hl };
            //Animal[] S5 = { cs, hs, hm, hl, hl };
            //Animal[] S6 = { cs, cs, cs, hm, hm, hl, hl, hl };
            //Animal[] S7 = { cs, cs, cs, cs, cs, cs, cs, cm, cm, cm, hm, hm, hm, hm, hm, cl, cl, cl, hl, hl, hl, hl, hl, hl };
            //Animal[] S8 = { };

            // size then inverted type 
            //    definitly not it
            //Animal[] S1 = { hl, hl, hm, hm, hm, cs };
            //Animal[] S2 = { hl, hm, hm, hs, hs, hs, hs, hs, cs };
            //Animal[] S3 = { hl, cl, hm, cm, hs, cs };
            //Animal[] S4 = { hl, cl, hm, hm, hm, hm, hm, cm, hs, cs, cs };
            //Animal[] S5 = { hl, hl, hm, hs, cs };
            //Animal[] S6 = { hl, hl, hl, hm, hm, cs, cs, cs };
            //Animal[] S7 = { hl, hl, hl, hl, hl, hl, cl, cl, cl, hm, hm, hm, hm, hm, cm, cm, cm, cs, cs, cs, cs, cs, cs, cs };
            //Animal[] S8 = { };


            Scenarios[0] = S1.ToList();
            Scenarios[1] = S2.ToList();
            Scenarios[2] = S3.ToList();
            Scenarios[3] = S4.ToList();
            Scenarios[4] = S5.ToList();
            Scenarios[5] = S6.ToList();
            Scenarios[6] = S7.ToList();
            Scenarios[7] = S8.ToList();
        }

        [TestCase(0, 2)]
        [TestCase(1, 2)]
        [TestCase(2, 4)]
        [TestCase(3, 5)]
        [TestCase(4, 2)]
        [TestCase(5, 3)]
        [TestCase(6, 13)]
        [TestCase(7, 0)]
        public void TrainCart_AreEqualTest(int Scenario, int ExpectedCarts)
        {
            Animal[] ToBeSorted = Scenarios[Scenario].ToArray();
            Train Train = new Train();
            int CartCount = Train.FillCarts(ToBeSorted);
            Assert.AreEqual(ExpectedCarts, CartCount);
        }

        [TestCase(0, 0, false)]
        [TestCase(0, 1, false)]
        [TestCase(0, 2, false)]
        [TestCase(0, 3, false)]
        [TestCase(0, 4, false)]
        [TestCase(0, 5, false)]
        [TestCase(1, 0, false)]
        [TestCase(1, 1, false)]
        [TestCase(1, 2, false)]
        [TestCase(1, 3, false)]
        [TestCase(1, 4, false)]
        [TestCase(1, 5, false)]
        [TestCase(2, 0, false)]
        [TestCase(2, 1, false)]
        [TestCase(2, 2, false)]
        [TestCase(2, 3, false)]
        [TestCase(2, 4, false)]
        [TestCase(2, 5, false)]
        [TestCase(3, 0, true)]
        [TestCase(3, 1, true)]
        [TestCase(3, 2, true)]
        [TestCase(3, 3, true)]
        [TestCase(3, 4, true)]
        [TestCase(3, 5, true)]
        [TestCase(4, 0, false)]
        [TestCase(4, 1, true)]
        [TestCase(4, 2, true)]
        [TestCase(4, 3, false)]
        [TestCase(4, 4, true)]
        [TestCase(4, 5, true)]
        [TestCase(5, 0, false)]
        [TestCase(5, 1, false)]
        [TestCase(5, 2, true)]
        [TestCase(5, 3, false)]
        [TestCase(5, 4, false)]
        [TestCase(5, 5, true)]
        public void AnimalEating_AreEqualTest(int Animal1, int Animal2, bool WillTheyEatEachother) => Assert.AreEqual(Animals[Animal1].CanEat(Animals[Animal2]), WillTheyEatEachother);
    }
}