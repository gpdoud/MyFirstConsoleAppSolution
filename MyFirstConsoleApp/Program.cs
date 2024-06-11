namespace MyFirstConsoleApp;

/*
 * This is my first class
 */

/// <summary>
/// This is a cool class!
/// </summary>
internal class Program {

    static int i = 0;
    static int? j = null;

    // Property
    public static string Name { get; set; } = "Greg"; // property

    // Method
    static void Main(string[] args) { // method

        Program pgm = new Program();

        Console.WriteLine($"Hello, {Name} World!");
    }

    static void Print(string message) { 
        Console.WriteLine(message);
    }

}

