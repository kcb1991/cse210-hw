public class Entry
{
    public string _date;
    public string _prompt;
    public string _entry;
    private string dateText;
    private string promptText;
    private string entryText;

    public Entry(string dateText, string promptText, string entryText)
    {
        this.dateText = dateText;
        this.promptText = promptText;
        this.entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_entry}");
    }
}