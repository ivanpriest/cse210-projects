// creating the class
public class Comment
{
    // declaring the attributes
    private string _nameOfCommentor;
    private string _commentText;

    // declaring the constructor
    public Comment ()
    {

    }
    // declaring the mutator/setter methods
    public void SetCommentorsName(string name)
    {
      _nameOfCommentor=name;
    }
     public void SetCommentText(string comment)
    {
        _commentText=comment;
    }

    // declaring the retriver/getter methods

    public string GetCommetorsName()
    {
        return _nameOfCommentor;
    }
    public string GetComment()
    {

        return _commentText;
    }
}