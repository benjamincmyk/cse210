using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your score: ");
        string userInput = Console.ReadLine();
        int score = int.Parse(userInput);

        string grade = "";
        if (score >= 90)
        {
            grade="A";
        }
        else if (score >= 80)
        {
            grade="B";
        }
        else if (score >= 70)
        {
            grade="C";
        }
        else if (score >= 60)
        {
            grade="D";
        }
        else 
        {
            grade="F";
        }
        Console.WriteLine($"Your grade is {grade}.");


        if (score>=70)
        {
            Console.WriteLine("Congratulations! You passes the course.");
        }
        else
        {
            Console.WriteLine("Keep working hard for next time.");
        }
    
    }
}