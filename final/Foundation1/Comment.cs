public class Comment
{
    // Attributes
    private string CommenterName;
    private string CommentText;

    // Constructor
    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }

    // Getter methods
    public string GetCommenterName()
    {
        return CommenterName;
    }

    public string GetCommentText()
    {
        return CommentText;
    }
}
