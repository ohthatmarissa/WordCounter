using System;

namespace WordCounter.Models
{
  public class Words
  {
    private string _sentence;
    private string _oneWord;
    private string[] _array;

    public Words (string sentence, string oneWord)
    {
      _sentence = sentence;
      _oneWord = oneWord;
      _array = sentence.Split(' ');
    }
    public string[] TurnToArray()
    {
      return _array;
    }
    // public string GetSentence()
    // {
    //   return _sentence;
    // }
    // public void SetSentenceAndOneWord(string newSentence, string newOneWord)
    // {
    //   _sentence = newSentence;
    //   _oneWord = newOneWord;
    // }
    // public string GetOneWord()
    // {
    //   return _oneWord;
    // }
    // public void SetWord()
    // {
    //   _word = newWord;
    // }

  }
}
