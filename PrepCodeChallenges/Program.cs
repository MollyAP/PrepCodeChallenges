using System;

class Program
{
    static void Main()
    {
        // Problem 1: Array Max Result
        int[] numbers = new int[5];
        Console.WriteLine("One by one please enter five numbers between 1 and 10:");
        for (int i = 0; i < numbers.Length; i++)
        {
            int input;
            if (int.TryParse(Console.ReadLine(), out input) && input >= 1 && input <= 10)
            {
                numbers[i] = input;
            }
            else
            {
                Console.WriteLine("I said a number between 1 and 10. :(");
                i--;
            }
        }

        Console.WriteLine("Pick one of the previous numbers!");
        int selectedNumber;
        if (int.TryParse(Console.ReadLine(), out selectedNumber))
        {
            int score = CalculateScore(numbers, selectedNumber);
            Console.WriteLine("Your score is... " + score + "!!!!>u<");
        }
        else
        {
            Console.WriteLine("That input is wrong. :( Try entering a valid number!");
        }

        // Problem 2: Leap Year Calculator
        Console.WriteLine("Enter a year and I'll tell you if it's a leap year:");
        int year;
        if (int.TryParse(Console.ReadLine(), out year))
        {
            bool isLeapYear = IsLeapYear(year);
            Console.WriteLine("Leap Year: " + isLeapYear);
        }
        else
        {
            Console.WriteLine("That ain't a year.");
        }
    }

    static int CalculateScore(int[] numbers, int selectedNumber)
    {
        int score = 0;
        foreach (int num in numbers)
        {
            if (num == selectedNumber)
                score += num;
        }
        return score;
    }

    static bool IsLeapYear(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                    return true;
                else
                    return false;
            }
            else
            {
                return true;
            }
        }
        else
        {
            return false;
        }
    }
}
