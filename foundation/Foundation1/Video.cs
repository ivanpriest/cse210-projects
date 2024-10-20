// creating the video class
public class Video
{
    // declaring the attributes
    private string _title;
    private string _author;
    private int _videoLength;
    private List<Comment> _comments=new List<Comment>();
    // declaring the constructor(s)
    public Video()
    {

    }
    // declaring the Setter/mutator method
    public void SetTitle(string title)
    {
        _title=title;
    }
    public void SetAuthor(string author)
    {
        _author=author;
    }
    public void SetVideoLength(int videoLength)
    {
        _videoLength=videoLength;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    // declaring the getter/retriver methods
    public string GetTitle()
    {
      return _title;
    }
    public string GetAuthor()
    {
      return _author;
    }
    public int GetVideoLength()
    {
      return _videoLength;
    }
     public int GetNumberOfComment()
    {
      return _comments.Count();
    }
    public List<string> GetCommentList()
    {
        List<string> listOfCommentText =new List<string> ();
        foreach(Comment comment in _comments)
        {
            listOfCommentText.Add(comment.GetComment());
        }
        return listOfCommentText;
    }


}