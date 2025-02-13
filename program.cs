using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("**************");
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("**************");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            if (choice == "1")
                Console.WriteLine("Starting a new game...");
            else if (choice == "2")
                Console.WriteLine("Loading game...");
            else if (choice == "3")
                Console.WriteLine("Opening options...");
            else if (choice == "4")
                break;
            else
                Console.WriteLine("Invalid choice! Try again.");

            Console.ReadLine();
        }
    }
}
