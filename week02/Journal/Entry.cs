using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _place;
    public string _motivationalQuote;

    public Entry(string date, string promptText, string entryText, string place, string motivationalQuote)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _place = place;
        _motivationalQuote = motivationalQuote;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt Question: {_promptText}");
        Console.WriteLine($"Your Response: {_entryText}");
        Console.WriteLine($"Location of Entry: {_place}");
        Console.WriteLine($"Motivational Quote: {_motivationalQuote}");
        Console.WriteLine("--------------------------------------------------");
    }

   
    public string ToCsv()
    {
        return $"{_date}|{_promptText}|{_entryText}|{_place}|{_motivationalQuote}";
    }

    
    public static Entry FromCsv(string csvLine)
    {
        string[] parts = csvLine.Split('|');
        return new Entry(parts[0], parts[1], parts[2], parts[3], parts[4]);
    }
}