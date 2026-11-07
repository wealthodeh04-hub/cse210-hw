using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine();
            Console.WriteLine("=== ALL ASSIGNMENTS IN ONE ===");
            Console.WriteLine("1. Your Name");
            Console.WriteLine("2. Letter Grade");
            Console.WriteLine("3. Guess My Number Game");
            Console.WriteLine("4. List of Numbers");
            Console.WriteLine("5. Functions - Square Number");
            Console.WriteLine("6. Quit");
            Console.Write("What do you want to run? (1-6): ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                NameAssignment();
            }
            else if (choice == "2")
            {
                GradeAssignment();
            }
            else if (choice == "3")
            {
                GuessGame();
            }
            else if (choice == "4")
            {
                ListAssignment();
            }
            else if (choice == "5")
            {
                FunctionsAssignment();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice, try again.");
            }
        }
    }

    static void NameAssignment()
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }

    static void GradeAssignment()
    {
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

        string letter = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter != "F")
        {
            int lastDigit = grade % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }

            if (letter == "A" && sign == "+")
            {
                sign = "";
            }
        }

        Console.WriteLine($"Your letter grade is {letter}{sign}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Don't give up! You'll do better next time. Keep trying!");
        }
    }

    static void GuessGame()
    {
        string playAgain = "yes";
        while (playAgain == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1;
            int guessCount = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"It took you {guessCount} guesses.");
            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine().ToLower();
        }
    }

    static void ListAssignment()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number;
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        int sum = numbers.Sum();
        double average = numbers.Count > 0 ? numbers.Average() : 0;
        int largest = numbers.Count > 0 ? numbers.Max() : 0;
        int smallest = numbers.Count > 0 ? numbers.Min() : 0;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Largest: {largest}");
        Console.WriteLine($"Smallest: {smallest}");
    }

    static void FunctionsAssignment()
    {
        Console.Write("Enter a number to square: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"The square of {number} is {SquareNumber(number)}.");
    }

    static int SquareNumber(int value)
    {
        return value * value;
    }
}