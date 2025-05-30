
public class Video
{
    private string _title;
    private string _author;
    private int _length = 0;
    private List<Comment> _comments;

    public Video (string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine("Comments:");
        
        foreach (var comment in _comments)
        {
            Console.WriteLine($"- {comment.GetDisplayText()}");
        }
    }
}