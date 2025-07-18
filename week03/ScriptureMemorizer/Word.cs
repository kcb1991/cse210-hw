using System.Text.RegularExpressions;

public class Word
{
    private string Text;
    private string CoreText;
    private string Punctuation;
    public bool IsVisible { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsVisible = true;

        Match match = Regex.Match(text, @"^(\w+)(\W*)$");
        CoreText = match.Groups[1].Value;
        Punctuation = match.Groups[2].Value;
    }
    public void Hide()
    {
        IsVisible = false;
    }
    public void Show()
    {
        IsVisible = true;
    }

    public string GetDisplayText()
    {
        if (IsVisible)
        {
            return Text;
        }
        else
        {
            return new string('_', CoreText.Length) + Punctuation;
        }
    }
}