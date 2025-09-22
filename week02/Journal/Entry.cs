public class Entry
{

    public string _name;
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"This journal belongs to: {_name}");
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}