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

    public void SaveToFile(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                sw.WriteLine($"Date: {entry._date}");
                sw.WriteLine($"Prompt: {entry._prompt}");
                sw.WriteLine($"Entry: {entry._entry}");
                sw.WriteLine();
            }
            Console.WriteLine($"Your journal entry has been save to file  '{filename}'.");
        }
        ;
    }

    public void LoadFromFile(string file)
    {
        
    }
}