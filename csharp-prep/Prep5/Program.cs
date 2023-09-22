using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessege();

        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        int squaredNum = SquareNumber(userNum);
        DisplayResult(userName, squaredNum);
    }
    static void DisplayWelcomeMessege()
    {
        Console.WriteLine("Welcome to the Program!");

    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is you favorite number (write it as an interger)? ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}. ");
    }


}