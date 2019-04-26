namespace WordCounter.Models
{
  public class Words
  {
    private string _sentence;

    public Words (string sentence)
    {
      _sentence = sentence;
      // _word = word;
    }
    public string GetSentence()
    {
      return _sentence;
    }
    public void SetSentence(string newSentence)
    {
      _sentence = newSentence;
    }
    // public void GetWord()
    // {
    //   return _word;
    // }
    // public void SetWord()
    // {
    //   _word = newWord;
    // }

  }
}
