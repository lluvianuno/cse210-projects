using System.Dynamic;
using System.Transactions;

class Video
{
    private string _title;
    private string _author;
    private int _lenght;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lenght)
    {
        _title = title;
        _author = author;
        _lenght = lenght;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count();
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLenght()
    {
        return _lenght;
    }
}