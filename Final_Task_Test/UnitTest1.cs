using Final_Task;

namespace Final_Task_Test
{
    [TestClass]
    internal class SorterTest
    {
        [TestMethod]
        public void AnimalsFileSorterTest()
        {
            List<Animal> expected = new List<Animal>();
            expected.Add(new Horse("Snowflake", 2017, "White", "Arabian Horse"));
            expected.Add(new Horse("Storm", 2015, "Bay", "Orlov Trotter"));
            expected.Add(new Donkey("Riley", 2015, "Mammoth Donkey", 1.75));

            List<Animal> actual = Sorter.AnimalsFileSorter("C:\\Users\\user\\source\\repos\\TestFinalTask\\bin\\Debug\\TestAnimals.txt");

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WhiteHorsesTest()
        {
            List<Horse> expected = [new Horse("Snowflake", 2017, "White", "Arabian Horse")];

            List<Horse> actual = Sorter.WhiteHorses(Sorter.AnimalsFileSorter("C:\\Users\\user\\source\\repos\\TestFinalTask\\bin\\Debug\\TestAnimals.txt"));

            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void LowerDonkeyTest()
        {
            List<Donkey> expected = new List<Donkey>();
            expected.Add(new Donkey("Gizmo", 2012, "Standard Donkey", 1.2));

            List<Donkey> actual = Sorter.DonkeysLowerThan(Sorter.AnimalsFileSorter("C:\\Users\\user\\source\\repos\\TestFinalTask\\bin\\Debug\\TestAnimals.txt"), 1.5);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}