using System.IO;
using System.IO;public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._name}|{e._date}|{e._promptText}|{e._entryText}");
            }
        }
    }

    public void LoadFromFile()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry e = new Entry();
            e._name = parts[0];
            e._date = parts[1];
            e._promptText = parts[2];
            e._entryText = parts[3];
            _entries.Add(e);
        }

    }   

}

