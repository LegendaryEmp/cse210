using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please input your grade percentage: ");
        string gradeInput = Console.ReadLine();
        int grade = int.Parse(gradeInput);

        string letter = "";
        if (grade  >= 90){
            letter = "A";
        }
        else if (grade  >= 80){
            letter = "B";;
        }
        else if (grade  >= 70){
            letter = "C";
        }
        else if (grade  >= 60){
            letter = "D";
        }
        else {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");
        if (grade >= 70) {
            Console.WriteLine("Congratulations, you have passed this course.");
        }
        else {
            Console.WriteLine("Oops! You did not make it this time. Please put in more time for better grades next time.");
        }
    }
}