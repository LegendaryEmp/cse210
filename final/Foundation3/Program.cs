using System;


class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("Alcron street", "Homecrave", "NT", "USA");
        Address address2 = new Address("23 Albert CL", "Mega Town", "LT", "Canada");
        Address address3 = new Address("181 Wine St", "Home Town", "TX", "USA");

        // Create events
        Lecture lectureEvent = new Lecture("Business Talk", "Talk on how to grow your business", new DateTime(2024, 02, 19), "09:00 AM", address1, "Henry", 49);
        Reception receptionEvent = new Reception("Networking", "An evening on how to network and socialize", new DateTime(2024, 03, 15), "5:20 PM", address2, "getintouch@mail.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Family Get Togther", "A fun family meet up", new DateTime(2024, 04, 13), "12:00 PM", address3, "Sunny");

        // Display messages for each event
        Console.WriteLine("Lecture Event:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(lectureEvent.GetShortDescription());

        Console.WriteLine("\nReception Event:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(receptionEvent.GetShortDescription());

        Console.WriteLine("\nOutdoor Gathering Event:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(outdoorEvent.GetShortDescription());
    }
}
