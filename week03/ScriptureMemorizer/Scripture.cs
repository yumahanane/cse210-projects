using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        //List<Word> _words = new List<Word>();
        //Word aWord = new Word(text);
        //string[] words = text.Split(' ');
        //foreach (string word in words)
        // {
        // word = aWord;
        //}
        //string[] word = new string[]
        //{
        // text
        //};

        string[] word = text.Split(' ');
        object[] eachWord = new object[word.Length];
        for (int x = 0; x < word.Length; x++)
        {
            eachWord[x] = word[x];
        }
        
    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }

}