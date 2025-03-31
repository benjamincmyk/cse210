using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;
        Journal journal = new Journal();
        journal.LoadFromFile();
        
        
        do 
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.WriteLine("What would you like to do?");
            string answer = Console.ReadLine();
            number = int.Parse(answer);

            if (number == 1)
            {
                PromptGenerator prompt = new PromptGenerator();
                string showprompt = prompt.GetRandomPrompt();
                Console.WriteLine($"{showprompt}");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();
                
                journal.AddEntry(new Entry(date, showprompt, response));
                
            }
            
            else if (number==2)
            {
                
                journal.DisplayAll();
            }
            else if (number == 3) 
            {
                journal.LoadFromFile();
            }
            else if (number ==4)
            {
                journal.SaveToFile();
            }
        } while ( number<5);
        

    }
}