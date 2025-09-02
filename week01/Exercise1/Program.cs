using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.Write("What is your first name? ");
        string Fname = Console.ReadLine();
        Console.Write("What is your last name? ");
        string Lname = Console.ReadLine();
        Console.Write($"Your name is {Lname}, {Fname} {Lname}.");

        Console.ReadLine();
    }
}