public class ScriptureLibrary
{
    private List<Scripture> Scriptures = new List<Scripture>();
    private Random random = new Random();

    public void LoadFromTextFile(string filePath)
{
    var lines = File.ReadAllLines(filePath);
    foreach (string line in lines)
    {
        var match = Regex.Match(line, @"^(.*?) (\d+):(\d+)(?:–(\d+))? — (.+)$");
        if (match.Success)
        {
            string book = match.Groups[1].Value.Trim();
            int chapter = int.Parse(match.Groups[2].Value);
            int startVerse = int.Parse(match.Groups[3].Value);
            int endVerse = match.Groups[4].Success ? int.Parse(match.Groups[4].Value) : startVerse;
            string text = match.Groups[5].Value.Trim();

            var reference = new Reference(book, chapter, startVerse, endVerse);
            var scripture = new Scripture(reference, text);
            Scriptures.Add(scripture);
        }
    }
}


    public Scripture GetRandomScripture()
    {
        if (Scriptures.Count == 0) return null;
        return Scriptures[random.Next(Scriptures.Count)];
    }
}