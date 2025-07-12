using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        string _prompt = PromptGenerator.GetRandomPrompt();
        Console.WriteLine(_prompt);
        string _entry = Console.ReadLine();
        string _date = DateTime.Now.ToString("MM/dd/yyyy");

        Entry newEntry = new Entry(_date, _prompt, _entry);

        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
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

        using (StreamWriter sw = new StreamWriter(filename, append: true))
        {
            foreach (Entry entry in _entries)
            {
                sw.WriteLine($"Date: {entry._date}");
                sw.WriteLine($"Prompt: {entry._prompt}");
                sw.WriteLine($"Entry: {entry._entry}");
                sw.WriteLine();
            }
            Console.WriteLine($"Your journal entry has successfully been saved to file: '{filename}'.");
        }
        ;
    }

    public void LoadFromFile()
    {
        Console.WriteLine();
        Console.WriteLine("Please type a filename to load.");
        string filename = Console.ReadLine().Trim();

        string[] lines = System.IO.File.ReadAllLines(filename);

        for (int i = 0; i < lines.Length; i += 4)
        {
            string dateText = lines[i].Replace("Date: ", "").Trim();
            string promptText = lines[i + 1].Replace("Prompt: ", "").Trim();
            string entryText = lines[i + 2].Replace("Entry:", "").Trim();

            Entry entry = new(dateText, promptText, entryText);
            _entries.Add(entry);

        }
        Console.WriteLine($"Your journal entries have been successfully loaded from file: '{filename}' ");
    }
    public void SearchEntries(string keyword)
    {
        var matches = _entries
        .Where(e => e._entry.Contains(keyword, StringComparison.OrdinalIgnoreCase));

        if (!matches.Any())
        {
            Console.WriteLine($"No entries contain the keyword: '{keyword}'.");
        }
        else
        {
            Console.WriteLine($"Entries that contain the keyword: '{keyword}'.");
            foreach (var entry in matches)
            {
                entry.Display();
            }
        }
    }
}