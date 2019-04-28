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
    // [TestMethod]
    // public void TurnWordsToUpper_TurnWordsToUpper_UpperCaseString()
    // {
    //   string sentence = "Kittytopia is the best place to see kitties and find your kitty best friend";
    //   string oneWord = "kitty";
    //   string upper = "KITTYTOPIA IS THE BEST PLACE TO SEE KITTIES AND FIND YOUR KITTY BEST FRIEND";
    //   Words newWords = new Words(sentence, oneWord);
    //   Assert.AreEqual(upper, newWords.TurnWordsToUpper());
    // }

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
      // [TestMethod]
      // public void SetSentenceAndOneWord_SetSentenceAndOneWord_String()
      // {
      //   string sentence = "Kittytopia is the best place to see kitties and find your kitty best friend!";
      //   string oneWord = "kitty";
      //   Words newWords = new Words(sentence, oneWord);
      //   string newSentence = "Puppytopia is the best place to see puppies and find your puppy best friend";
      //   string newOneWord = "puppy";
      //   newWords.SetSentenceAndOneWord(newSentence, newOneWord);
      //   string result = newWords.WordsConstructor();
      //   Assert.AreEqual(newSentence, newOneWord, result);
      // }
    // }
    // [TestMethod]
    // public void GetSentence_ReturnsSentence_String()
    // {
    //   string sentence = "Kittytopia is the best place to see kitties and find your kitty best friend!";
    //   Words newWords = new Words(sentence);
    //   string result = newWords.GetSentence();
    //   Assert.AreEqual(sentence, result);
    // }
    // [TestMethod]
    // public void SetSentence_SetSentence_String()
    // {
    //   string sentence = "Kittytopia is the best place to see kitties and find your kitty best friend!";
    //   Words newWords = new Words(sentence);
    //   string updatedSentence = "Puppytopia is the best place to see puppies and find your puppy best friend";
    //   newWords.SetSentence(updatedSentence);
    //   string result = newWords.GetSentence();
    //   Assert.AreEqual(updatedSentence, result);
    // }
    // [TestMethod]
    // public void GetOneWord_ReturnsOneWord_String()
    // {
    //   string oneWord = "kitty";
    //   Words newWords = new Words(oneWord);
    //   string result = newWords.GetOneWord();
    //   Assert.AreEqual(oneWord, result);

  }
}
