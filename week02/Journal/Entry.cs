public class Entry
{
    public string _date;
    public string _prompt;
    public string _entry;

    public Entry(string dateText, string promptText, string entryText)
    {
        _date = dateText;
        _prompt = promptText;
        _entry = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_entry}");
        Console.WriteLine();
    }
}