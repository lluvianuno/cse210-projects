using System.Collections.Generic;
class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(' ');
        foreach (string w in splitWords)
        {
            _words.Add(new Word(w));
        }
    }

    public void HideRandomWords(int numberToHide)
{
    Random random = new Random();
    int count = 0;

    while (count < numberToHide)
    {
        int i = random.Next(_words.Count);
        
        if (!_words[i].IsHidden())
        {
            _words[i].Hide();
            count++;
        }

        bool allHidden = true;
        foreach (var w in _words)
        {
            if (!w.IsHidden())
            {
                allHidden = false;
                break;
            }
        }
        if (allHidden)
            break;
    }
}

    public string GetDisplayText()
    {
        string display = _reference.GetDisplayText();
        foreach (Word w in _words)
        {
            display += w.GetDisplayText() + " ";
        }
        return display.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
                return false;
        }
        return true;
    }
}