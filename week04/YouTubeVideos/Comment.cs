
public class Comment
{
    private string _name;
    private string _commentText;

    public Comment(string name, string commentText)
    {
        _name = name;
        _commentText = commentText;
    }

    public string GetDisplayText()
    {
        return $"{_name}: {_commentText}";
    }
}