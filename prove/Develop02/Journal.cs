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
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.Write($"Date: {entry._date}|");
                outputFile.Write($"Prompt Text: {entry._promptText}|");
                outputFile.WriteLine($"Entry: {entry._entryText}");
                
            }

        }

    }

    public void LoadFromFile(string file)
    {
        // Removess all entries
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(file);

        // Splits the stored entries and stores them as new entries.
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string _date = parts[0];
        
            string _prompt = parts[1];
            string _entry = parts[2];

            Entry entry = new Entry();
            entry._date = _date;
    
            entry._promptText = _prompt;
            entry._entryText = _entry;
            AddEntry(entry);
        }

    }

    
}