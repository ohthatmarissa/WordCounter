using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordsTest
  {
    [TestMethod]
    public void WordsConstructor_CreateInstanceOfWords_Words()
    {
      string sentence = "Kittytopia is the best place to see kitties and find your kitty best friend";
      string oneWord = "kitty";
      Words newWords = new Words(sentence, oneWord);
      Assert.AreEqual(typeof(Words), newWords.GetType());
    }
    [TestMethod]
    public void TurnWordsToUpper_TurnWordsToUpper_UpperCaseString()
    {
      string sentence = "Kittytopia is the best place to see kitties and find your kitty best friend";
      string oneWord = "kitty";
      string upper = "KITTYTOPIA IS THE BEST PLACE TO SEE KITTIES AND FIND YOUR KITTY BEST FRIEND";
      Words newWords = new Words(sentence, oneWord);
      Assert.AreEqual(upper, newWords.TurnWordsToUpper(sentence, oneWord));
    }

    [TestMethod]
    public void TurnToArray_TurnToArray_Array()
    {
      string sentence = "Kittytopia is the best place to see kitties and find your kitty best friend";
      string oneWord = "kitty";
      string[] result = new string[] {"Kittytopia", "is", "the", "best", "place", "to", "see", "kitties", "and", "find", "your", "kitty", "best", "friend"};
      Words newWords = new Words(sentence, oneWord);
      CollectionAssert.AreEqual(result, newWords.TurnToArray());
    }

    [TestMethod]
    public void Counting_HowManyTimesWordInSentence_Int()
    {
      string sentence = "Kittytopia is the best place to see kitties and find your kitty best friend";
      string oneWord = "kitty";
      int result = 1;
      Words newWords = new Words(sentence, oneWord);
      Assert.AreEqual(result, newWords.Counting());
    }

  }
}
