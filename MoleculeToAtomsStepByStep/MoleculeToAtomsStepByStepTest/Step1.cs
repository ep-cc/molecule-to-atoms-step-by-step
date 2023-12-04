namespace MoleculeToAtomsStepByStep;


public class Step1
{
    [Test]
    public void TestEmptyString()
    {
        CollectionAssert.AreEquivalent(
          new Dictionary<string, int> {},
          Kata.ParseMolecule("")
        );
    }

    [Test]
    public void TestSingleCharacter()
    {
        CollectionAssert.AreEquivalent(
          new Dictionary<string, int> {{"H", 3}},
          Kata.ParseMolecule("HHH")
        );
    }

    [Test]
    public void TestRandomCharacters()
    {
        CollectionAssert.AreEquivalent(
          new Dictionary<string, int> {{"H", 4}, {"N", 1}, {"O", 4}},
          Kata.ParseMolecule("HOHHOONOH")
        );
    }
}