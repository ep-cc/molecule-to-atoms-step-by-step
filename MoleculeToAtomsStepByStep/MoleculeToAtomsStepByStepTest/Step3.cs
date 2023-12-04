namespace MoleculeToAtomsStepByStep;


public class Step3
{
    [Test]
    public void TestWithMg()
    {
        CollectionAssert.AreEquivalent(
          new Dictionary<string, int> {{"H", 2}, {"Mg", 1}, {"O", 1}},
          Kata.ParseMolecule("MgO2H2")
        );
    }

    [Test]
    public void TestSalt()
    {
        CollectionAssert.AreEquivalent(
          new Dictionary<string, int> {{"Cl", 1}, {"Na", 1}},
          Kata.ParseMolecule("NaCl")
        );
    }

    [Test]
    public void TestWithNa()
    {
        CollectionAssert.AreEquivalent(
          new Dictionary<string, int> {{"C", 1}, {"Na", 2}, {"O", 3}},
          Kata.ParseMolecule("Na2CO3")
        );
    }
}