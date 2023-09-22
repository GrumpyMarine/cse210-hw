using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();
        int userNum = -1;
        
        while (userNum != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            string userInfo = Console.ReadLine();
            userNum = int.Parse(userInfo);


            if (userNum !=0)
            {
                numbers.Add(userNum);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The total is: {sum} ");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largestNum = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largestNum)
            {
                largestNum = number;
            }
        }

        Console.WriteLine($"The largest number is: {largestNum} ");
    }
}