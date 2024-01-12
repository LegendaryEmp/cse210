using System;

class Program
{
    static void Main(string[] args)
    {
        //Input from the user
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        //output to the console
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}