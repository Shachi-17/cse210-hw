using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine(" Entry successfully added!");
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine(" No entries to display.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine(entry.ToCsv());
                }
            }
            Console.WriteLine($" Entries saved to {file}");
        }
        catch
        {
            Console.WriteLine(" Error saving journal.");
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        try
        {
            using (StreamReader reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        _entries.Add(Entry.FromCsv(line));
                    }
                }
            }
            Console.WriteLine($" Journal loaded from {file}");
        }
        catch
        {
            Console.WriteLine($" File '{file}' not found.");
        }
    }

    public void SearchEntries(string keyword)
    {
        var results = _entries.FindAll(e =>
            e._entryText.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
            e._promptText.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
            e._place.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
            e._motivationalQuote.Contains(keyword, StringComparison.OrdinalIgnoreCase));

        if (results.Count == 0)
        {
            Console.WriteLine($" No entries found containing '{keyword}'.");
        }
        else
        {
            Console.WriteLine($" Found {results.Count} entries matching '{keyword}':");
            foreach (Entry entry in results)
            {
                entry.Display();
            }
        }
    }
}