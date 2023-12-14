using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("123 University St", "Cityville", "CA", "USA");
        Address receptionAddress = new Address("456 Event Ave", "Partytown", "NY", "USA");
        Address outdoorGatheringAddress = new Address("789 Park Rd", "Sunnyville", "FL", "USA");

        Lecture lectureEvent = new Lecture("Tech Talk", "An informative tech lecture", DateTime.Now, new TimeSpan(14, 0, 0), lectureAddress, "John Speaker", 100);

        Reception receptionEvent = new Reception("Networking Mixer", "A social networking event", DateTime.Now.AddDays(7), new TimeSpan(18, 30, 0), receptionAddress, "rsvp@example.com");

        OutdoorGathering outdoorGatheringEvent = new OutdoorGathering("Picnic in the Park", "Enjoy a day outdoors", DateTime.Now.AddDays(14), new TimeSpan(12, 0, 0), outdoorGatheringAddress, "Sunny and clear skies");

        Console.WriteLine("Lecture Event:");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception Event:");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Event:");
        Console.WriteLine(outdoorGatheringEvent.GetStandardDetails());
        Console.WriteLine(outdoorGatheringEvent.GetFullDetails());
        Console.WriteLine(outdoorGatheringEvent.GetShortDescription());
    }
}