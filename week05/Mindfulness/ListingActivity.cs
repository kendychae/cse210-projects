using System;
using System.Threading;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", 
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _count = 0;
    }

    public override void Run()
    {
        DisplayStartingMessage();
        
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> items = GetListFromUser();
        Console.WriteLine($"You listed {items.Count} items!");
        
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            
            // Simple input method - read until enter or time runs out
            string response = "";
            DateTime inputStart = DateTime.Now;
            
            while (DateTime.Now < endTime)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine();
                        if (!string.IsNullOrWhiteSpace(response))
                        {
                            items.Add(response);
                        }
                        break;
                    }
                    else if (key.Key == ConsoleKey.Backspace && response.Length > 0)
                    {
                        response = response.Substring(0, response.Length - 1);
                        Console.Write("\b \b");
                    }
                    else if (!char.IsControl(key.KeyChar))
                    {
                        response += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                Thread.Sleep(50);
            }
            
            // If time ran out during input, break
            if (DateTime.Now >= endTime)
            {
                Console.WriteLine();
                break;
            }
        }
        
        return items;
    }
}
