using System;

namespace LeetSpeak
{
  public class LeetSpeakTranslator
  {
    public string CharacterReplacer(string enteredLetterWordOrPhrase)
    {

      if (enteredLetterWordOrPhrase == "")
      {
        
      }
      else if (enteredLetterWordOrPhrase == "s")
      {
        return "z";
      }
      else if (enteredLetterWordOrPhrase == "t")
      {
        return "7";
      }
      else if (enteredLetterWordOrPhrase == "I")
      {
        return "1";
      }
      else if (enteredLetterWordOrPhrase == "o")
      {
        return "0";
      }
      else
      {
        return "3";

      }
    }
  }
}
