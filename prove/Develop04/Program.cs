using System;
using System.Threading;

namespace RelaxationApp
{
    class Program
    {
        private static bool activityTimedOut = false;

        static void Main(string[] args)
        {
            Console.Clear();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Relaxation App!");

                Console.WriteLine("\nChoose an activity:");
                Console.WriteLine("1. Breathing");
                Console.WriteLine("2. Reflection");
                Console.WriteLine("3. Listing");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        BreathingActivity();
                        break;
                    case 2:
                        ReflectionActivity();
                        break;
                    case 3:
                        ListingActivity();
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using the app! Have a relaxing day.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void StartActivity(string activityName, string description, out int duration)
        {
            Console.Clear();
            Console.WriteLine($"Starting {activityName} Activity");
            Console.WriteLine(description);
            Console.Write("Enter the duration in seconds: ");
            duration = int.Parse(Console.ReadLine());

            Console.WriteLine("Prepare to begin...");
            ShowAnimation(3);
        }

        static void ShowAnimation(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        static void EndActivity()
        {
            Console.WriteLine("You did a great job! ");
            ShowAnimation(2);
            Console.WriteLine("You have completed the activity.");
            ShowAnimation(2);
            Console.WriteLine("Press enter key to continue!");
            Console.ReadLine();
        }

        // Breathing Activity 
        static void BreathingActivity()
        {
            StartActivity("Breathing", "This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.", out int duration);

            for (int i = 0; i < duration; i += 4)
            {
                Console.WriteLine("Breathe in...");
                ShowCountdown(3);
                Console.WriteLine("Breathe out...");
                ShowCountdown(3);
            }

            EndActivity();
        }

        // Reflection Activity 
        static void ReflectionActivity()
        {
            StartActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", out int duration);

            string[] prompts = {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };
            string[] questions = {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };

            Random random = new Random();
            Console.WriteLine(prompts[random.Next(prompts.Length)]);
            ShowCountdown(5);

            int elapsedTime = 0;
            while (elapsedTime < duration && !activityTimedOut)
            {
                Console.WriteLine(questions[random.Next(questions.Length)]);
                ShowCountdown(4);
                elapsedTime += 4;
            }

            EndActivity();
            Console.WriteLine("Press enter key to continue!");
            Console.ReadLine();
        }

        static void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i} ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

      // Listing Activity
        static void ListingActivity()
        {
            StartActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", out int duration);

            string[] prompts = {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };

            Random random = new Random();
            Console.WriteLine(prompts[random.Next(prompts.Length)]);
            ShowCountdown(5);

            int elapsedTime = 0;
            int itemCount = 0;

    
            Thread timeoutThread = new Thread(() =>
            {
                Thread.Sleep(duration * 1000);
                activityTimedOut = true;
            });

            timeoutThread.Start();

            while (elapsedTime < duration && !activityTimedOut)
            {
                Console.Write("Enter an item: ");
                string item = Console.ReadLine();
                itemCount++;
                elapsedTime += 2; 
            }

            
            timeoutThread.Join();

            Console.WriteLine($"You listed {itemCount} items.");
            EndActivity();
            Console.WriteLine("Press enter key to continue!");
            Console.ReadLine();
        }
    }
}
