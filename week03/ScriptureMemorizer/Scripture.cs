public class Scripture
{
    public Reference Reference{ get; private set; }
    private List<Word> Words;

    public Scripture(Reference _reference, string text)
    {
        Reference = _reference;
        Words = new List<Word>();

        string[] splitText = text.Split(' ');
        foreach (string word in splitText)
        {
            Word newWord = new Word(word);
            Words.Add(newWord);
        }
    }
    public void GetDisplayText()
    {
        Console.WriteLine(Reference.ToString());
        Console.WriteLine();

        foreach (Word word in Words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine("\n");
    }
    public void HideRandomWords(int count)
    {
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in Words)
        {
            if (word.IsVisible)
            {
                visibleWords.Add(word);
            }
        }
        Random random = new Random();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in Words)
        {
            if (word.IsVisible)
            {
                return false;
            }
        }
        return true;
    }
}