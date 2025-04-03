// Greetings.cs
using System;

// This class contains methods for greeting messages
public class Greetings
{
    // Method to print a welcome message
    public void Welcome()
    {
        Console.WriteLine("Welcome to our C# program!");
    }

    // Method to print a personalized greeting message
    public void Hello(string name)
    {
        Console.WriteLine($"{name}, thank you for joining us today!");
    }
}

// Program.cs
using System;

// Main program class
class Program
{
    static void Main()
    {
        // Create an instance of the Greetings class
        Greetings greetings = new Greetings();

        // Call the Welcome method
        greetings.Welcome();

        // Call the Hello method with a sample name
        greetings.Hello("Alice"); // Replace "Alice" with any name
    }
}
