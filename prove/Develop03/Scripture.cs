public class Scripture
{
    private Reference _reference;
    private List<Word> _words = [];
    private string _difficulty;

    public Scripture(Reference reference, string text, string difficulty) {
        _reference = reference;
        _difficulty = difficulty;
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide) 
    {
        int num = numberToHide;
        if (_words[num].isHidden())
        {
            Random rnd = new Random();
            do
            {
                num = rnd.Next(_words.Count());
                
            }while (_words[num].isHidden());
        }
        _words[num].Hide();
    }

    public string GetDisplayText() 
    {
        string scriptureVerse = "";

        foreach (Word word in _words)
        {
            scriptureVerse += $" {word.GetDisplayText(_difficulty)}";
        }

        return $"{_reference.GetDisplayText()}{scriptureVerse}";
    }

    public bool IsCompletelyHidden() 
    {
        bool hidden = true;
        foreach (Word word in _words)
        {
            if (!word.isHidden())
            {
                hidden = false;
            }
        }
        return hidden;
    }
}