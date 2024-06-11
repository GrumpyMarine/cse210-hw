using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)

    // {
    //     MainMenu();
    // }
    {
        Journal journal = new Journal();
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "How did I see the hand of the Lord in my life today?",
            "If you could have done something different today, what would have you done?",
            "What was the best part of your day?",
            "Who did you eat lunch with today?"
        };

        // static void MainMenu()

        while (true)

        {
            Console.WriteLine("");
            Console.WriteLine("Hello friend. Welcome to your Journal.");
            Console.WriteLine("");
            Console.WriteLine("Menu");
            Console.WriteLine("");
            Console.WriteLine("Option 1. Write in your journal.");
            Console.WriteLine("Option 2. Display the journal.");
            Console.WriteLine("Option 3. Save your thought.");
            Console.WriteLine("Option 4. Load a memory.");
            Console.WriteLine("Option 5. Quit");
            Console.WriteLine("Please choose an option. 1 thru 5");
            Console.Write("What is your option:  ");
            string options;
            options = Console.ReadLine();
            switch (options)
            {
                case "1":
                    string prompt = prompts[new Random().Next(prompts.Count)];
                    Console.WriteLine($"{prompt}");
                    Console.Write("Type your response here: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response);
                    break;

                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter the filename as .txt file: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveFile(saveFile);
                    Console.WriteLine($"The journal has been saved to {saveFile}");
                    break;

                case "4":
                    Console.Write("Please enter the filename to load:  ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFile(loadFile);
                    Console.WriteLine($"The journal entry loaded from {loadFile}. ");
                    break;

                case "5":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}