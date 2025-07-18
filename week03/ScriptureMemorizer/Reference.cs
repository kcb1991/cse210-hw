public class Reference
{
    private string Book;
    private int Chapter;
    private int StartVerse;
    private int EndVerse;

    public Reference(string _book, int _chapter, int _verse)
    {
        Book = _book;
        Chapter = _chapter;
        StartVerse = _verse;
        EndVerse = _verse;
    }

    public Reference(string _book, int _chapter, int _startVerse, int _endVerse)
    {
        Book = _book;
        Chapter = _chapter;
        StartVerse = _startVerse;
        EndVerse = _endVerse;
    }

    public string GetDisplayText()
    {
        if (StartVerse == EndVerse)
        {
            return $"{Book} {Chapter}:{StartVerse}";
        }
        else
        {
            return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
        }
    }

}