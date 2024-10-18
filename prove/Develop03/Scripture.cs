public class Scripture
{
    private Reference _reference;
    private List <Word> _words =new List<Word>();

    public Scripture (Reference reference,string text)
    {
        _reference=reference;
        _words.Clear();
        string[] words= text.Split(" ");
        foreach(string word in words)
        {
            Word newWord= new Word(word);
            _words.Add(newWord);
        }

    }
    public void HideRandomWords(int numberToHide)
    {
        _words[numberToHide].Hide();
    }

    public string GetDisplayText()
    {
        List<string> newText = new List<string>();
        foreach(Word word in _words)
        {
            newText.Add(word.GetDisplayText());

        }
        string displayText= string.Join(" ",newText);
       
        return displayText;
           
        
    }
    public bool IsCompletelyHidden()
    {
       bool hidden;    
       int numberOfWords= _words.Count();
       int numberOfHiddenWords=0;
       foreach(Word word in _words)
       {
        char[] lettersArray= word.GetDisplayText().ToCharArray();
        if (lettersArray[0] == '_')
        {
            numberOfHiddenWords+=1;
        }
       }
       if (numberOfHiddenWords==numberOfWords)
       {
        hidden=true;
       }
       else
       {
        hidden=false;
       }
       return hidden;
    }

}