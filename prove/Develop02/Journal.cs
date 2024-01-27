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
            Console.WriteLine(entry);
        }

    } 
    public void SaveToFile(string fileName)
    {

    }

    public void LoadFromFile(string fileName)
    {

    }
}