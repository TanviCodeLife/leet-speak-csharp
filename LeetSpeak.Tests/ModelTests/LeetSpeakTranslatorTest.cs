using Microsoft.VisualStudio.TestTools.UnitTesting;
// using LeetSpeak;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class LeetSpeakTranslatorTest
  {
    [TestMethod]
    public void CharacterReplacer_IsAnE_Three()
    {
      LeetSpeakTranslator newTest = new LeetSpeakTranslator();
      Assert.AreEqual("3", newTest.CharacterReplacer("e"));
    }

    [TestMethod]
    public void  CharacterReplacer_IsAnO_Zero()
    {
      LeetSpeakTranslator newTest = new LeetSpeakTranslator();
      Assert.AreEqual("0", newTest.CharacterReplacer("o"));
    }

    [TestMethod]
    public void CharacterReplacer_IsCapitalI_One()
    {
      LeetSpeakTranslator newTest = new LeetSpeakTranslator();
      Assert.AreEqual("1", newTest.CharacterReplacer("I"));
    }

    [TestMethod]
    public void CharacterReplacer_IsLetterT_Seven()
    {
      LeetSpeakTranslator newTest = new LeetSpeakTranslator();
      Assert.AreEqual("7", newTest.CharacterReplacer("t"));
    }

    [TestMethod]
    public void CharacterReplacer_IsLowerCaseS_Z()
    {
      LeetSpeakTranslator newTest = new LeetSpeakTranslator();
      Assert.AreEqual("z", newTest.CharacterReplacer("s"));
    }

  }
}
