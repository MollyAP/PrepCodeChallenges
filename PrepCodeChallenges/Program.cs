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
}