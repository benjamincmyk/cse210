using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        

        List<int> numbers = new List<int>();
        int number=-1;
        
        while(number!=0)
        {
            Console.Write("Enter number:");
            number = int.Parse(Console.ReadLine());
            if (number!=0)
            {
                numbers.Add(number);
            }
        }
        Console.WriteLine(numbers.Count);
        //SUM
        int sum=0;
        foreach ( int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        //AVERAGE
        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //MAX
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                
                max = num;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}