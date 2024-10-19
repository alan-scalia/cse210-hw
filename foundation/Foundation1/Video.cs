public class Video 
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = [];

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayVideo() 
    {
        Console.Write($"\n{_title} ({_length}) - {_author} - {GetNumberOfComments()} comments");
    }

    public void DisplayComments()
    {
        Console.Write($"\n\n{_comments.Capacity - 1} Comments:\n");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }

}