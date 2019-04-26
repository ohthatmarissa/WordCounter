namespace WordCounter.Models
{
  public class Words
  {
    private string _sentence;
    private string _oneWord;

    public Words (string sentence)
    {
      _sentence = sentence;
      // _oneWord = oneWord;
    }
    public string GetSentence()
    {
      return _sentence;
    }
    public void SetSentence(string newSentence)
    {
      _sentence = newSentence;
    }
    public string GetOneWord()
    {
      return _oneWord;
    }
    // public void SetWord()
    // {
    //   _word = newWord;
    // }

  }
}
