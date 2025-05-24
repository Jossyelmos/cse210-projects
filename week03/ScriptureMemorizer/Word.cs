public class Word
{
    public string _text;
    public bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }

    public void Hide()
    {
        _isHidden = true;
    }
}