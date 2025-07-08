public class Journal
{
    public List<string> _entries;

    public void AddEntry()
    {
        Console.WriteLine("Please enter a journal entry:");
        string _entryText = Console.ReadLine();
        string _date = DateTime.Now.ToString("MM/dd/yyyy");
    }

    public void DisplayAll()
    {

    }

    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {
        
    }
}