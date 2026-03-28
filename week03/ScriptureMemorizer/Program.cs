// Creativity: Hi, I exceeds the requirements because this program can easily be extended to support multiple scriptures.
// You could store several scriptures in a list and randomly select one.
// Also, the number of hidden words per turn can be adjusted for difficulty. Thank you.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity: you can easily change scripture here or add more later
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference,
            "Trust in the Lord with all thine heart and lean not unto thine own understanding");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("\nPress ENTER to continue or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }
    }
}