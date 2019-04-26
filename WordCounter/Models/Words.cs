namespace WordCounter.Models
{
  public class Words
  {
    private string _sentence;
    public Words (string sentence)
    {
      _sentence = sentence;
    }
    public string GetSentence()
    {
      return _sentence;
    }
  }
}
