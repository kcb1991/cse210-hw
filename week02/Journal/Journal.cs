using System.IO.Enumeration;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    Journal journal = new Journal();

    public void AddEntry()
    {
        string _prompt = PromptGenerator.GetRandomPrompt();
        Console.WriteLine(_prompt);
        string _entry = Console.ReadLine();
        string _date = DateTime.Now.ToString("MM/dd/yyyy");

        Entry newEntry = new Entry(_date, _prompt, _entry);
        newEntry._date = _date;
        newEntry._prompt = _prompt;
        newEntry._entry = _entry;

        _entries.Add(newEntry);



    }

    public void DisplayAll()
    {
        if (journal._entries.Count == 0)
        {
            Console.WriteLine("No journal entries found");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
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

    public void LoadFromFile()
    {
        Console.WriteLine("Please type a filename to load.");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        for (int i = 0; i < lines.Length; i += 4)
        {
            string dateText = lines[i].Replace("Date: ", "").Trim();
            string promptText = lines[i + 1].Replace("Prompt: ", "").Trim();
            string entryText = lines[i + 2].Replace("Entry:", "").Trim();

            Entry entry = new(dateText, promptText, entryText);
            _entries.Add(entry);

        }

    }
}