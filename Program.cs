using System;

// loops

// FOR LOOP


/*class Program
{
    static void Main()
    {
        double total = 0;

        for (int i = 1; i <= 3; i++)
        {
            double grade = ReadDoubleInRange($"Enter exam grade #{i} (0-100): ", 0, 100);
            total += grade;
        }

        double avg = total / 3.0;

        // If grades are out of 100, convert to a 0-1 fraction for percent formatting:
        double avgAsPercent = avg / 100.0;

        Console.WriteLine($"\nAverage Exam Grade: {avgAsPercent:P2}");
    }

    static double ReadDoubleInRange(string prompt, double min, double max)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (double.TryParse(input, out double value) && value >= min && value <= max)
                return value;

            Console.WriteLine($"Enter a number between {min} and {max}.");
        }
    }
}*/



// WHILE LOOP 


class ProgramWhilE
{
    static void Main()
    {
        double total = 0;
        int count = 0;

        while (true)
        {
            double score = ReadDoubleInRange("Enter an exam score (0-100): ", 0, 100);
            total += score;
            count++;

            Console.Write("Do you have another score to enter? (yes/no): ");
            string answer = (Console.ReadLine() ?? "").Trim().ToLower();

            if (answer != "yes" && answer != "y")
                break;
        }

        double avg = total / count;
        double avgAsPercent = avg / 100.0;

        Console.WriteLine($"\nYou entered {count} score(s).");
        Console.WriteLine($"Average: {avgAsPercent:P2}");
    }

    static double ReadDoubleInRange(string prompt, double min, double max)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (double.TryParse(input, out double value) && value >= min && value <= max)
                return value;

            Console.WriteLine($"Enter a number between {min} and {max}.");
        }
    }
}

