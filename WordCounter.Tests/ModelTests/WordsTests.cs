using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordsTest
  {
    [TestMethod]
    public void WordsConstructor_CreateInstanceOfWords_Words()
    {
      Words newWords = new Words("test");
      Assert.AreEqual(typeof(Words), newWords.GetType());
    }
    [TestMethod]
    public void GetSentence_ReturnsSentence_String()
    {
      string sentence = "Kittytopia is the best place to see kitties and find your kitty best friend!";
      Words newWords = new Words(sentence);
      string result = newWords.GetSentence();
      Assert.AreEqual(sentence, result);
    }
    [TestMethod]
    public void SetSentence_SetSentence_String()
    {
      string sentence = "Kittytopia is the best place to see kitties and find your kitty best friend!";
      Words newWords = new Words(sentence);
      string updatedSentence = "Puppytopia is the best place to see puppies and find your puppy best friend";
      newWords.SetSentence(updatedSentence);
      string result = newWords.GetSentence();
      Assert.AreEqual(updatedSentence, result);
    }
    // [TestMethod]
    // public void Word_GetWord_String()
    // {
    //   string word = "kitty";
    //   Words newWords = new Words(sentence);
    //   string result = newWords.GetWord();
    //   Assert.AreEqual(word, result)
    //
    // }
  }
}
