using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? (Pick from 1 to 100.)");
        // int magicNum = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1,101);

        int guess = -1;

        while (guess != magicNum)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNum > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNum < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You gueesed correct.");
            }
        }
    }
}