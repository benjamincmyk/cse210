using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? ");
        string fName = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string lName = Console.ReadLine();

        Console.WriteLine($"Your name is {lName}, {fName} {lName}.");
    }
}

// using System;

// class Program
// {
//     static void Main()
//     {
//         int x;
//         x = 6;
//         int y = 7;
//         Console.WriteLine(x);
//         Console.WriteLine("I don´t know");
//         Console.Write("What is your favorite color?");
//         string color = Console.ReadLine();

//         if (x<y)
//         {
//             Console.WriteLine("greater");
//         }
//     }
// }