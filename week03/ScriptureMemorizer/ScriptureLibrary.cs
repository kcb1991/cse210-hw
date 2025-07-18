public class ScriptureLibrary
{
    private List<Scripture> Scriptures = new List<Scripture>();
    private Random random = new Random();

    public void LoadMasteryScriptures()
    {
        Scriptures.Add(new Scripture(
            new Reference("1 Nephi", 3, 7),
            "I will go and do the things which the Lord hath commanded..."));

        Scriptures.Add(new Scripture(
            new Reference("2 Nephi", 2, 25),
            "Adam fell that men might be; and men are, that they might have joy."));

        Scriptures.Add(new Scripture(
            new Reference("Mosiah", 2, 17),
            "When ye are in the service of your fellow beings ye are only in the service of your God."));

        Scriptures.Add(new Scripture(
            new Reference("Alma", 37, 35),
            "O, remember, my son, and learn wisdom in thy youth..."));

        Scriptures.Add(new Scripture(
            new Reference("Helaman", 5, 12),
            "It is upon the rock of our Redeemer... that ye must build your foundation."));
    }

    public Scripture GetRandomScripture()
    {
        if (Scriptures.Count == 0) return null;
        return Scriptures[random.Next(Scriptures.Count)];
    }
}