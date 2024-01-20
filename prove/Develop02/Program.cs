using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    class Program
    {
        static List<Entry> journal = new List<Entry>();
        static string[] prompts = {
            "Did your day go as planned?",
            "What did you do today that you were no so proud of",
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "Are you having a day filled with stress? If yes, how do you intend to ease your stress?"

        };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                DisplayMenu();

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            WriteNewEntry();
                            break;
                        case 2:
                            DisplayJournal();
                            break;
                        case 3:
                            SaveJournalToFile();
                            break;
                        case 4:
                            LoadJournalFromFile();
                            break;
                        case 5:
                            Console.WriteLine("Exiting journal...");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }

    //Menu Items Display
        static void DisplayMenu()
        {
            Console.WriteLine("***** My Journal *****");
            Console.WriteLine("_______________________");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
        }

    //Journal Entry
        static void WriteNewEntry()
        {
            string randomPrompt = prompts[new Random().Next(prompts.Length)];
            Console.WriteLine(randomPrompt);
            string response = Console.ReadLine();
            journal.Add(new Entry(response, randomPrompt, DateTime.Now));
            Console.WriteLine("Entry saved successfully!");
        }

    //Display Journal
        static void DisplayJournal()
        {
            if (journal.Count == 0)
            {
                Console.WriteLine("The journal is currently empty.");
            }
            else
            {
                foreach (Entry entry in journal)
                {
                    Console.WriteLine($"{entry.Date.ToString("MM/dd/yyyy")} - Prompt: {entry.Prompt}");
                    Console.WriteLine(entry.Response);
                    Console.WriteLine("____________________________________________________________");
                }
            }
        }

    //Save journal
        static void SaveJournalToFile()
        {
            Console.Write("Enter the filename to save the journal: ");
            string filename = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in journal)
                {
                    writer.WriteLine($"{entry.Date.ToString("MM/dd/yyyy")}|{entry.Prompt}|{entry.Response}");
                }
            }

            Console.WriteLine("Journal saved successfully!");
        }

    //Loading Journal file
        static void LoadJournalFromFile()
        {
            Console.Write("Enter the filename to load the journal: ");
            string filename = Console.ReadLine();

            if (File.Exists(filename))
            {
                journal.Clear();

                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        DateTime date = DateTime.Parse(parts[0]);
                        string prompt = parts[1];
                        string response = parts[2];
                        journal.Add(new Entry(response, prompt, date));
                    }
                }

                Console.WriteLine("Journal loaded successfully!");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }

    class Entry
    {
        public string Response { get; set; }
        public string Prompt { get; set; }
        public DateTime Date { get; set; }

        public Entry(string response, string prompt, DateTime date)
        {
            Response = response;
            Prompt = prompt;
            Date = date;
        }
    }
}
