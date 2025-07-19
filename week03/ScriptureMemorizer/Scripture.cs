using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            Word aWord = new Word(word);
            _words.Add(aWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i <= numberToHide; i++)
        {
            var randomWords = new Random();
            int index = randomWords.Next(_words.Count);
            Word wordToHide = _words[index];

            wordToHide.Hide(); // calls Hide() method to set _isHidden to true
        }
        
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} {_words}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
            
        }

        return true;
    }

}