using System.Text.RegularExpressions;

public class ScriptureLibrary
{
    private List<Scripture> Scriptures = new List<Scripture>();
    private Random random = new Random();

    public void LoadFromTextFile(string filePath)
{
    string[] lines = File.ReadAllLines(filePath);

    foreach (string line in lines)
    {
        string[] splitLine = line.Split(" — ");
        if (splitLine.Length != 2)
            continue;

        string referenceText = splitLine[0].Trim();
        string scriptureText = splitLine[1].Trim();

        
        Match match = Regex.Match(referenceText, @"^(.*?) (\d+):(\d+)(?:-(\d+))?$");

        if (!match.Success)
            continue; 

        string bookName = match.Groups[1].Value;
        int chapter = int.Parse(match.Groups[2].Value);
        int startVerse = int.Parse(match.Groups[3].Value);
        int endVerse = match.Groups[4].Success ? int.Parse(match.Groups[4].Value) : startVerse;

        
        Reference reference = new Reference(bookName, chapter, startVerse, endVerse);
        Scripture scripture = new Scripture(reference, scriptureText);

        Scriptures.Add(scripture);
    }
}



    public Scripture GetRandomScripture()
    {
        if (Scriptures.Count == 0) return null;
        return Scriptures[random.Next(Scriptures.Count)];
    }
}