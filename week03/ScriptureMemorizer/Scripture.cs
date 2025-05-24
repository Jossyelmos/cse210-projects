public class Scripture
{
    public Reference _reference;
    public List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + "\n";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }
        return text.Trim();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            Word word = _words[random.Next(_words.Count)];
            if (!word._isHidden)
            {
                word.Hide();
            }
            else
            {
                i--;
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word._isHidden)
            {
                return false;
            }
        }
        return true;
    }

}