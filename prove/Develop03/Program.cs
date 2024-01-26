using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the scripture reference:");
        string book = Console.ReadLine();
        int chapter, startVerse, endVerse;

        Console.WriteLine("Enter the chapter number:");
        int.TryParse(Console.ReadLine(), out chapter);

        Console.WriteLine("Enter the start verse number:");
        int.TryParse(Console.ReadLine(), out startVerse);

        Console.WriteLine("Enter the end verse number (optional, press Enter to skip):");
        int.TryParse(Console.ReadLine(), out endVerse);

        Reference userReference = endVerse != 0
        ? new Reference(book, chapter, startVerse, endVerse)
        : new Reference(book, chapter, startVerse);




        Console.WriteLine("Enter the scripture text:");
        string userText = Console.ReadLine();

        // Save the scripture to a txt file
        SaveToFile(userReference, userText);

        // Loading the scripture from the txt file
        var savedScripture = LoadFromFile();

        Console.Clear();
        DisplayScripture(savedScripture);


    //loop
        while (savedScripture.HasVisibleWords())
        {
            Console.Write("Press Enter to hide words or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input.ToLowerInvariant() == "quit")
            {
                break;
            }

            savedScripture.HideRandomWords();
            Console.Clear();
            DisplayScripture(savedScripture);
        }
    }

    static void SaveToFile(Reference reference, string text)
    {
        string fileName = "saved_scripture.txt";
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine($"{reference.Book},{reference.Chapter},{reference.StartVerse},{(reference.EndVerse.HasValue ? reference.EndVerse.Value.ToString() : "")},{text}");

        }

        Console.WriteLine($"Scripture saved to {fileName}");
    }

    static Scripture LoadFromFile()
{
    string fileName = "saved_scripture.txt";

    if (File.Exists(fileName))
    {
        string[] lines = File.ReadAllLines(fileName);
        string[] values = lines[0].Split(',');

        string book = values[0];
        int chapter = int.Parse(values[1]);
        int startVerse = int.Parse(values[2]);
        int.TryParse(values[3], out int endVerse);
;
        string text = values[4];

        return new Scripture(new Reference(book, chapter, startVerse, endVerse), text);
    }
    else
    {
        Console.WriteLine($"File {fileName} does not exist. Please save a scripture first.");
        return null;
    }
}


    static void DisplayScripture(Scripture scripture)
    {
        Console.WriteLine(scripture.Reference.ToString());
        Console.WriteLine(scripture.GetHiddenText());
    }
}


class Scripture
{
    public Reference Reference { get; }
    public string Text { get; }

    private List<Word> words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Text = text;
        words.AddRange(text.Split(' ').Select(w => new Word(w)));
    }


    public bool HasVisibleWords()
    {
        return words.Any(word => !word.hidden);
    }


    public void HideRandomWords()
    {
        int wordsToHide = 2;
        Random random = new Random();

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(words.Count);
            words[index].Hide();
        }
    }

    public string GetHiddenText()
    {
        return string.Join(" ", words.Select(w => w.hidden ? "____" : w.Text));
    }
}

class Reference
{
    public string Book { get; }
    public int Chapter { get; }
    public int StartVerse { get; }
    public int? EndVerse { get; }

    public Reference(string book, int chapter, int startVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        return $"{Book} {Chapter}:{StartVerse}{(EndVerse.HasValue ? "-" + EndVerse : "")}";
    }
}

class Word
{
    public string Text { get; }
    public bool hidden { get; private set; }

    public Word(string text)
    {
        Text = text;
    }

    public void Hide()
    {
        hidden = true;
    }
}
