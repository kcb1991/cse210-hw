using System.IO.Enumeration;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        string _prompt = PromptGenerator.GetRandomPrompt();
        Console.WriteLine(_prompt);
        string _entry = Console.ReadLine();
        string _date = DateTime.Now.ToString("MM/dd/yyyy");

        Entry newEntry = new Entry();
        newEntry._date = _date;
        newEntry._prompt = _prompt;
        newEntry._entry = _entry;

        _entries.Add(newEntry);



    }

    public void DisplayAll()
    {

    }

    public void SaveToFile(string file)
    {
        using (StreamWriter sw = new StreamWriter(file))
        {
            
        }
    }

    public void LoadFromFile(string file)
    {
        
    }
}