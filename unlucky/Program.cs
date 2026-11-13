// Welcome screen
Console.WriteLine("unlucky\nA simple C# Console App project that shows all occurrences of Friday the 13th within a certain range of two dates.");
Console.Write("Press any key to continue..."); // Wait for the user
Console.ReadKey();
Console.WriteLine("\n");

// Create Range
//   First Date:
Console.Write("Year of first date of range: ");
string firstDateYear = Console.ReadLine();
Console.Write("Month of first date of range: ");
string firstDateMonth = Console.ReadLine();
DateOnly firstDate = new(int.Parse(firstDateYear), int.Parse(firstDateMonth), 1);
string firstDateFormatted = firstDate.ToString("yyyy-MM");
Console.WriteLine($"First date: {firstDateFormatted}\n");


//   Last Date:
Console.Write("Year of last date of range: ");
string lastDateYear = Console.ReadLine();
Console.Write("Month of last date of range: ");
string lastDateMonth = Console.ReadLine();
DateOnly lastDate = new(int.Parse(lastDateYear), int.Parse(lastDateMonth), 1);
string lastDateFormatted = lastDate.ToString("yyyy-MM");
Console.WriteLine($"Last date: {lastDateFormatted}\n");
Console.WriteLine($"Created range: {firstDateFormatted}-{lastDateFormatted}\n\n");

// Exit screen
Console.WriteLine("Press any key to exit...");
Console.ReadKey();