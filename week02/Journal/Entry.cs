public class Entry
{
    public string Date {get; set;}
    public string Prompt {get; set;}
    public string Response {get; set;}

    public Entry(string _date, string _prompt, string _response)
    {
        Date = _date;
        Prompt = _prompt;
        Response = _response;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {Date} Prompt: {Prompt} Response: {Response} ");
    }
    
}