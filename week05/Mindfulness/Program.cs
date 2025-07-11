using System;

/*
 * W05 Mindfulness Program
 * 
 * Exceeding Requirements:
 * 1. Enhanced animation for breathing activity with variable countdown timing (4 seconds in, 6 seconds out)
 * 2. Improved user input handling in listing activity with real-time typing and backspace support
 * 3. Added a more robust prompt selection system
 * 4. Enhanced spinner animation with multiple characters for better visual feedback
 * 5. Clear screen functionality for better user experience
 * 6. Added input validation and error handling
 */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        string choice = "";
        while (choice != "4")
        {
            DisplayMenu();
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;
                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the Mindfulness Program!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity"); 
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
    }
}