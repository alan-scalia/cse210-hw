public class Word 
{
    private string _text;
    private bool _isHidden;

    public Word(string text) 
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide() 
    {
        _isHidden = true;
    }   
    public void Show()
    {
        _isHidden = false;
    }

    public bool isHidden() 
    {
        return _isHidden;
    }

    public string GetDisplayText(string difficulty) 
    {
        if (_isHidden)
        {
            string hiddenWord = "";
            
            for (int i = 0; i < _text.Length; i++)
            {
                if(i == 0 && difficulty == "easy")
                {
                    hiddenWord += _text[i];
                }
                else
                {
                    hiddenWord += '_';
                }
            }
            return hiddenWord;
        }
        else
        {
            return _text;
        }
    }
}

