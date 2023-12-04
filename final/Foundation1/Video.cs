public class Video
{
    // Attributes
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    private int numberOfComments;

    // Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    // Method to add a comment
    public void AddComment(string commenterName, string commentText)
    {
        Comment comment = new Comment(commenterName, commentText);
        _comments.Add(comment);
    }

    // Method to get the number of comments
    public void SetNumberOfComments()
    {
        numberOfComments = _comments.Count;
    }
    public int GetNumberOfComments()
    {
        return numberOfComments;
    }

    // Getter methods
    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    // Getter method to retrieve the list of comments
    public List<Comment> GetComments()
    {
        return _comments;
    }
}
