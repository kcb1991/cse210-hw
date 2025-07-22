public class Video
{
    public string Title{get; private set;}
    public string Author{get; private set;}
    public int Length{get; private set;}

    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(string CommenterName,string CommentText)
    {
        comments.Add(new(CommenterName,CommentText));
    }
    public int GetCommentCount()
    {
        return comments.Count;
    }

}