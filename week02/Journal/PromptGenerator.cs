using System;
using System.Collections.Generic;

class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What did I learn today that helped me grow as a person?",
        "What small but meaningful moment did I experience today?",        
	    "How did I show gratitude or love to someone today?",
	    "What challenge did I face today, and how did I handle it?",
	    "What do I want to remember about this day a year from now?",
    };
    public Random random= new Random();
    public string GetRandomPrompt()
    {
       int randomPrompt = random.Next(_prompts.Count);
       return _prompts[randomPrompt];
    }  
}