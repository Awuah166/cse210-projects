using System;
using System.Reflection.Metadata.Ecma335;

public class Journal
{

    public List<Entry> _entries;
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        // Loop through each entry in the list and call its DisplayEntry method
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string filename = "journal.txt")
    {
        // Saving to a file the user specifys
        Console.Write("Enter the filename to save the journal: ");
        filename = Console.ReadLine();

        using (StreamWriter writer = new(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}"); // Using a delimiter to separate date and content
            }
        }
        Console.WriteLine($"Journal saved successfully to '{filename}'.");
        

    }

    public void LoadFromFile(string filename = "journal.txt")
    {
        Console.Write("Enter filename to load from: ");
        filename = Console.ReadLine();
        // Loading from the file save by the user
        if (File.Exists(filename))
        {
            List<Entry> loadedEntries = new List<Entry>();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        Entry entry = new Entry();
                        entry._date = parts[0].Trim();
                        entry._promptText = parts[1].Trim();
                        entry._entryText = parts[2].Trim();
                        loadedEntries.Add(entry);
                    }
                }
            }
        }

        else
        {
            Console.WriteLine($"File not found: {filename}");
        }
        
    }
}