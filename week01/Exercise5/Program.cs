using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Runs ALL assignments in order, in ONE code
        NameAssignment();
        Console.WriteLine();

        GradeAssignment();
        Console.WriteLine();

        GuessGame();
        Console.WriteLine();

        ListAssignment();
        Console.WriteLine();

        FunctionsAssignment();
    }

    // ===== 1. YOUR NAME =====
    static void NameAssignment()
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }

    // ===== 2. LETTER GRADE =====
    static void GradeAssignment()
    {
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

        string letter = "";
        string sign = "";

        if (grade >= 90) letter = "A";
        else if (grade >= 80) letter = "B";
        else if (grade >= 70) letter = "C";
        else if (grade >= 60) letter = "D";
        else letter = "F";

        int lastDigit = grade % 10;
        if (lastDigit >= 7) sign = "+";
        else if (lastDigit < 3) sign = "-";
        else sign = "";

        if (letter == "A" && sign == "+") sign = "";
        if (letter == "F") sign = "";

        Console.WriteLine($"Your letter grade is {letter}{sign}.");

        if (grade >= 70) Console.WriteLine("Congratulations! You passed the course!");
        else Console.WriteLine("Don't give up! You'll do better next time. Keep trying!");
    }

    // ===== 3. GUESS MY NUMBER =====
    static void GuessGame()
    {
        string playAgain = "yes";
        while (playAgain == "yes")