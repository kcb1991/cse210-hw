public class Comment
{
    public string CommenterName;
    public string CommentText;

    public string comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
        return $"{commenterName}:{commentText}";
    }
}