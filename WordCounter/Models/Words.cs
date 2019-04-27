using System;

namespace WordCounter.Models
{
  public class Words
  {
    private string _sentence;
    private string _oneWord;

    public Words (string sentence, string oneWord)
    {
      _sentence = sentence;
      _oneWord = oneWord;
    }
    // public string GetSentence()
    // {
    //   return _sentence;
    // }
    public void SetSentenceAndOneWord(string newSentence, string newOneWord)
    {
      _sentence = newSentence;
      _oneWord = newOneWord;
    }
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
