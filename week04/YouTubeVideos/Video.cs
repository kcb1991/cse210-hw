public class Video
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int Length { get; private set; }

    public List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }
    public override string ToString()
    {
        return $"Title: {Title}\n Author: {Author}\n Length: {Length} seconds\n Comments: {comments.Count}";
    }

    public void AddComment(string commenterName, string commentText)
    {
        Comment newComment = new Comment(commenterName, commentText);
        comments.Add(newComment);
    }
    public int GetCommentCount()
    {
        return comments.Count;
    }
    public List<Comment> GetComments()
    {
        return new List<Comment>(comments);
    }

}