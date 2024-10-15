using System;

public class Program
{
    public static void Main(string[] args)
    {
        /* Console.WriteLine("Walk in the room.");
        Console.WriteLine("Walk towards desk.");
        Console.WriteLine("Pull out chair.");
        Console.WriteLine("Take off backpack.");
        Console.WriteLine("Place backpack on the ground.");
        Console.WriteLine("Sit down in chair.");
        Console.WriteLine("Turn on computer.");
        Console.WriteLine("Sign in to computer.");
        Console.WriteLine("Open browser.");
        Console.WriteLine("Navigate to the Daily Logic Classroom.");
        Console.WriteLine("Complete the Daily Logic for the day.");
        Console.WriteLine("Inhale for 4 seconds.");
        Console.WriteLine("Hold breath for 4 seconds.");
        Console.WriteLine("Exhale for 4 seconds.");
        Console.WriteLine("Hold breath for 4 seconds.");
        Console.WriteLine("Inhale for 4 seconds.");
        Console.WriteLine("Hold breath for 4 seconds.");
        Console.WriteLine("Exhale for 4 seconds.");
        Console.WriteLine("Hold breath for 4 seconds.");
        Console.WriteLine("Inhale for 4 seconds.");
        Console.WriteLine("Hold breath for 4 seconds.");
        Console.WriteLine("Exhale for 4 seconds.");
        Console.WriteLine("Hold breath for 4 seconds.");
        Console.WriteLine("Inhale for 4 seconds.");
        Console.WriteLine("Hold breath for 4 seconds.");
        Console.WriteLine("Exhale for 4 seconds.");
        Console.WriteLine("Hold breath for 4 seconds.");
        Console.WriteLine("Inhale for 4 seconds.");
        Console.WriteLine("Hold breath for 4 seconds.");
        Console.WriteLine("Exhale for 4 seconds.");
        Console.WriteLine("Hold breath for 4 seconds.");
        Console.WriteLine("Open a new tab in the browser.");
        Console.WriteLine("Navigate to Google.");
        Console.WriteLine("Open Gmail.");
        Console.WriteLine("Read Daily Hypothetical.");
        Console.WriteLine("Talk to neighbors about Daily Hypothetical.");
        Console.WriteLine("Respond to Daily Hypothetical email."); */

        // STEP 3.b - Uncomment the lines below after your functions have been defined
        FindSeat();
        SignIn();
        DailyLogic();

        BoxBreathing(5);
        DailyHypothetical();
    }

    public static void FindSeat()
    {
        Console.WriteLine("Walk in the room.");
        Console.WriteLine("Walk towards desk.");
        Console.WriteLine("Pull out chair.");
        Console.WriteLine("Take off backpack.");
        Console.WriteLine("Place backpack on the ground.");
        Console.WriteLine("Sit down in chair.");
    }

    public static void SignIn()
    {
        Console.WriteLine("Turn on computer.");
        Console.WriteLine("Sign in to computer.");
    }

    public static void DailyLogic()
    {
        Console.WriteLine("Open browser.");
        Console.WriteLine("Navigate to the Daily Logic Classroom.");
        Console.WriteLine("Complete the Daily Logic for the day.");
    }

    /**
    * Create functions for Box Breathing and Daily Hypotheticals below:
    */

    public static void BoxBreathing(int interval)
    {
        Random dice = new Random();
        int max = dice.Next(3, 7);
        //How to generate random number in C# taken from https://stackoverflow.com/questions/2706500/how-do-i-generate-a-random-integer-in-c

        for (int cycle = 0; cycle < max; cycle++)
        {
            Console.WriteLine("Inhale for " + interval + " seconds.");
            Console.WriteLine("Hold breath for " + interval + " seconds.");
            Console.WriteLine("Exhale for " + interval + " seconds.");
            Console.WriteLine("Hold breath for " + interval + " seconds.");
        }
    }

    public static void DailyHypothetical()
    {
        Console.WriteLine("Open a new tab in the browser.");
        Console.WriteLine("Navigate to Google.");
        Console.WriteLine("Open Gmail.");
        Console.WriteLine("Read Daily Hypothetical.");
        Console.WriteLine("Talk to neighbors about Daily Hypothetical.");
        Console.WriteLine("Respond to Daily Hypothetical email.");
    }
}