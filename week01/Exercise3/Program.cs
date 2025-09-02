using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");


        Random rand = new Random();
        int magic = rand.Next(1, 101);


        Console.Write("What is your GUESS? ");
        int guess = int.Parse(Console.ReadLine());


        while (guess != magic)
        {
            if (guess < magic)
            {
                Console.WriteLine("HIGHER");
            }
            else
            {
                Console.WriteLine("LOWER");
            }

            Console.Write("What is your GUESS? ");
            guess = int.Parse(Console.ReadLine());
        }


        Console.WriteLine("You guessed it!");
    }
}