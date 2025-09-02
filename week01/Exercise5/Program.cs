using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string Uname = PromptUname();

        int Favnum = PromptUnum();

        int Squarenum = SquareNum(Favnum);

        DisplayResult(Uname, Squarenum);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

      
        static string PromptUname()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }


        static int PromptUnum()
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            return number;
        }


        static int SquareNum(int number)
        {
            return number * number;
        }


        static void DisplayResult(string name, int Squarenum)
        {
            Console.WriteLine($"{name}, the square of your number is {Squarenum}");

        }
    }
}