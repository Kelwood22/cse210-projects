using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101); 

        int guess = -1;
        int attempts = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            attempts++;

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it! You took {attempts} attempts.");
                Console.WriteLine("Do you want to play again? (yes/no)");
                string response = Console.ReadLine().ToLower();
                if (response == "yes")
                {
                    magicNumber = randomGenerator.Next(1, 101); 
                    guess = -1;
                    attempts = 0; 
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }
            }
        }  
    }
}