using System;
public class Journal
{

    public List<Entry> _entries = new List<Entry>();

    
    

    public void AddEntry(Entry anEntry)
    {
        _entries.Add(anEntry);    
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine("");
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._promptText}");
            Console.WriteLine($"Entry: {entry._entryText}");
            Console.WriteLine("");
        }
        

    } 
    public void SaveToFile(string fileName)
    {

    }

    public void LoadFromFile(string fileName)
    {

    }
}