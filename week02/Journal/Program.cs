using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("-------<3--- Welcome to Your Journal ---<3-------");

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. View Entries");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Search Journal");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);

                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    Console.Write("Location of entry: ");
                    string location = Console.ReadLine();

                    Console.Write("Do you have an uplifting, motivational or prophet qoutes drawn from this experience? 'just press enter if none' ");
                    string quote = Console.ReadLine();

                    string currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    Entry newEntry = new Entry(currentDate, prompt, response, location, quote);
                    journal.AddEntry(newEntry);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    Console.Write("Enter a keyword to search: ");
                    string keyword = Console.ReadLine();
                    journal.SearchEntries(keyword);
                    break;

                case "6":
                    Console.WriteLine(" Goodbye! Keep writing and stay inspired.");
                    return;

                default:
                    Console.WriteLine(" Invalid option, please try again.");
                    break;
            }
        }
    }
}