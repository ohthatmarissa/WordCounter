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
      //Asserts that the constructor returns an object with type Words
      Assert.AreEqual(typeof(Words), newWords.GetType());

      //Asserts that the constructor is properly setting the sentence property
      string result = newWords.GetSentence();
      Assert.AreEqual(sentence, result);

      //Asserts that the constructor is properly setting the oneWord property
      string resultOneWord = newWords.GetOneWord();
      Assert.AreEqual(oneWord, resultOneWord);

      //Assert that the constructor is properly computing the array property
      string[] expectedArray = sentence.Split(' ');
      string[] resultArray = newWords.GetArray();
      CollectionAssert.AreEqual(expectedArray, resultArray);
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
