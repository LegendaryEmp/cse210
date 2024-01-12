using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string magic = Console.ReadLine();

        // int magicNum = int.Parse(magic);
        Random randomNum = new Random();
        int randomGen = randomNum.Next(1, 100);
    
        int guess = -1;
    
        Console.WriteLine("Welcome to the guessing game");
        Console.WriteLine("__________________________________");
        while (guess != randomGen){
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();

            guess = int.Parse(guessInput);
            
            if (guess > randomGen){
                Console.WriteLine("Lower");
            }
            else if (guess < randomGen){
                Console.WriteLine("Higher");
            }
            else {
                Console.WriteLine("Congrats! You guessed it.");
            }
        }
    }
}