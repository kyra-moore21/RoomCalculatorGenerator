// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;
Console.WriteLine("Welcome to the Room Calculator Generator");

// user input length
Console.WriteLine("Enter Length: ");
decimal length = decimal.Parse(Console.ReadLine());

//user input width 
Console.WriteLine("Enter Width: ");
decimal width = decimal.Parse(Console.ReadLine());

// user input height
Console.WriteLine("Enter Height: ");
decimal height = decimal.Parse(Console.ReadLine());


// formulas 
decimal area = length * width;
decimal perimeter = (length + width) * 2;
decimal surfaceArea = 2 * (length * width + length * height + height * width);
decimal volume = width * length * height;


// console output
Console.WriteLine($"Area: {area}");
Console.WriteLine($"Perimeter: {perimeter}");
Console.WriteLine($"Volume: {volume}");
Console.WriteLine($"Surface Area: {surfaceArea}");

// switch statement for room size
switch (area)
{
    case <= 250:
        Console.WriteLine("This is a small sized room.");
        break;
    case > 250 and < 650:
            Console.WriteLine("This is a medium sized room.");
        break;
    case >= 650:
        Console.WriteLine("This is a large sized room.");
        break;
}

/* old if statement
 * (area <= 250)
{
    Console.WriteLine("This is a small sized room.");
}
else if (area > 250 && area < 650)
{
    Console.WriteLine("This is a medium sized room.");
} else if (area >= 650)
{
    Console.WriteLine("This is a large sized room.");
}

// goodbye
Console.WriteLine("Thanks for using the Room Calculator Generator!");
*/
