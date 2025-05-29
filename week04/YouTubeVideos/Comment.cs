public class Comment
{
    public string _commenterName;
    public string _commentText;

    public Comment(string commentName, string commentText)
    {
        _commenterName = commentName;
        _commentText = commentText;
    }

    public void DisplayComments()
    {
        Console.WriteLine($" - {_commenterName}: {_commentText}");
    }
}