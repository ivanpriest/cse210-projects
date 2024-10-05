
using System.IO;
public class Journal
{
    public List<Entry>_entries=new List<Entry>();
    

    public Journal ()
    {

    }

    public void AddEntry (Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        Console.WriteLine($"Saving to file {filename}...");
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
    }

    public void LoadFromfile(string filename)
    {
        Console.WriteLine($"Loading from {filename}...");
        string[] lines = System.IO.File.ReadAllLines(filename);
        _entries.Clear();
        foreach (string line in lines)
     {
        string[] values = line.Split(",");
        Entry newEntry= new Entry();
        newEntry._date = values[0];
        newEntry._promptText = values[1];
        newEntry._entryText= values[2];
        _entries.Add(newEntry);
     }

    }

}