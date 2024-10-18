public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text=text;
        if(_text =="_")
        {
            _isHidden=true;
        }
        else
        {
           _isHidden=false;
        }
    }
     
    public void Hide()
    {
        List<string> lettersList=new List<string>();
        char[] lettersArray= _text.ToCharArray();
        int arrayLen=lettersArray.Length;
        for(int i =0 ; i<arrayLen ; i++ )
        {
            lettersArray[i]='_';
            lettersList.Add(lettersArray[i].ToString());
        }
        _text=string.Join(null,lettersList);
        
        
        _isHidden= true;

    }
    public void Show()
    {
        Console.Write($"{_text}");  
    }
    public bool Ishidden()
    {   
        bool hidden=_isHidden;
        return hidden;
    }
    public string GetDisplayText()
    {
        return _text;

    }


}