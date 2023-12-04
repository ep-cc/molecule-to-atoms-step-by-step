namespace MoleculeToAtomsStepByStep;


public class Step2
{
    [Test]
    public void TestWater()
    {
        CollectionAssert.AreEquivalent(
          new Dictionary<string, int> {{"H", 2},{"O", 1}},
          Kata.ParseMolecule("H2O")
        );
    }

    [Test]
    public void TestMultipleNumbers()
    {
        CollectionAssert.AreEquivalent(
          new Dictionary<string, int> {{"H", 6}, {"O", 3}},
          Kata.ParseMolecule("H2O3H4")
        );
    }

    [Test]
    public void TestNoNumbers()
    {
        CollectionAssert.AreEquivalent(
          new Dictionary<string, int> {{"C", 1}, {"H", 1}, {"N", 1}, {"O", 1}},
          Kata.ParseMolecule("CHNO")
        );
    }
}