using System.Globalization;
using System.Text;
using LodgingProjectChallenge.Models;

CultureInfo.DefaultThreadCurrentCulture = new("en-US");
Console.OutputEncoding = Encoding.UTF8;

static void RunTest(int option)
{
    int numberOfGuests = option == 3 ? 4 : 2;
    int capacity = 3;
    int reservedDays = option == 2 ? 10 : 5;
    
    // Creates  the guest models and and adds them to the guest list
    List<Person> guests = new();

    for (int i = 0; i < numberOfGuests; i++)
    {
        guests.Add(new(name: $"Guest {i + 1}"));
    }

    // Creates the suite
    Suite suite = new(suiteType: "Premium", capacity, dailyRate: 30);

    // Creates a new reservation and registers the suite and the guests
    Reservation reservation = new(reservedDays);
    reservation.RegisterSuite(suite);
    reservation.RegisterGuests(guests);

    // Displays the number of guests and the final rate
    Console.WriteLine($"Guests: {reservation.GetGuestsCount()}");
    Console.WriteLine($"Daily rate: {reservation.CalculateFinalRate():c}");
}

while (true)
{
    Console.Clear();

    Console.WriteLine("Hello. Choose one of the test options:");
    Console.WriteLine("1 - Successful test");
    Console.WriteLine("2 - Successful test (discount)");
    Console.WriteLine("3 - Unsuccessful test (more guests than possible)");
    Console.WriteLine("4 - Quit");
    Console.WriteLine("Type one of the numbers and press Enter to choose an option.");

    int option;

    while (true)
    {
        bool valid = int.TryParse(Console.ReadLine(), out option) && option >= 1 && option <= 4;

        if (valid) break;

        Console.WriteLine("Invalid option! Try again.");
    }

    if (option == 4) break;

    Console.Clear();
    
    try
    {
        RunTest(option);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error has occurred: {ex.Message}");
    }

    Console.WriteLine("Press any key to go back to the menu.");
    Console.ReadKey();
}

Console.WriteLine("See you later.");
