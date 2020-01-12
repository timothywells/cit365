using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*Main Console Application Start*/
            /*Written by Tim Wells*/
            /*Naming Variables*/
            string fullName, location;

            /*Getting Variables*/
            Console.WriteLine("Please enter your name:");
            fullName = Console.ReadLine();
            Console.WriteLine("\nPlease enter your location");
            location = Console.ReadLine();

            /*Writing variables to console*/
            Console.WriteLine($"\nMy name is {fullName}.");
            Console.WriteLine($"I am from {location}.");

            /*Getting Today's Date*/
            Console.WriteLine("\nToday's date is " + DateTime.Now.ToString("d"));

            /*Giving the number of days until Christmas*/
            TimeSpan daysUntilChristmas = new DateTime(2020, 12, 25, 0, 0, 0).Subtract(DateTime.Now);
            Console.WriteLine("\nThere are " + daysUntilChristmas.Days + " days until Christmas.");

            /*Setting ReadKey to Pause before Glazer Application*/
            Console.WriteLine("\nPress any key to continue to the Glazer Application");
            Console.ReadKey();

            /*Clears Console before starting Glazer Application*/
            Console.Clear();

            /*Example 2.1 Window Glazer App*/
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            /*Glazer Application Start*/
            Console.WriteLine("Glazer Application");
            Console.WriteLine("\nWhat is the width of the window in feet?");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("\nWhat is the height of the window in feet?");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine($"\nThe length of the wood is {woodLength} feet");
            Console.WriteLine($"The area of the glass is {glassArea} metres");

            /*Setting ReadKey to pause program*/
            Console.WriteLine("\nPress any key to exit the program.");
            Console.ReadKey();
        }
    }
}
