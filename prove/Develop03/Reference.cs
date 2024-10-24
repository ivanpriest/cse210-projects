public class Reference
{
   private string _book;
   private int _chapter;
   private int _startVerse;
   private int _endVerse;

    public Reference(string book,int chapter,int verse)
    {
        _book=book;
        _chapter=chapter;
        _startVerse=verse;
    }
    public Reference(string book,int chapter,int verse,int endverse)
    {
        _book=book;
        _chapter=chapter;
        _startVerse=verse;
        _endVerse=endverse;
    }
    public string GetDisplayText()
    {
        string displayText;

        if(_endVerse > 0 )
        {
            displayText = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }

        else
        {
              
            displayText =$"{_book} {_chapter}:{_startVerse}";
        }
        return displayText;
        
    }    

   
}