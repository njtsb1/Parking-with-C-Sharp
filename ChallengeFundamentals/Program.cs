using ChallengeFundamentals.Models;

// Sets the encoding to UTF8 to display accents
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal initialPrice = 0;
decimal pricePerHour = 0;

Console.WriteLine("Welcome to the parking system!\n" +
                  "Enter starting price:");
initialPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Now enter the hourly price:");
pricePerHour = Convert.ToDecimal(Console.ReadLine());

// Instantiates the Parking class, with the values ​​obtained previously
Parking es = new Parking(initialPrice, pricePerHour);

string option = string.Empty;
bool displayMenu = true;

// Performs the menu loop
while (displayMenu)
{
    Console.Clear();
    Console.WriteLine("Enter your option:");
    Console.WriteLine("1 - Register vehicle");
    Console.WriteLine("2 - Remove vehicle");
    Console.WriteLine("3 - List vehicles");
    Console.WriteLine("4 - Close");

    switch (Console.ReadLine())
    {
        case "1":
            es.AddVehicle();
            break;

        case "2":
            es.RemoveVehicle();
            break;

        case "3":
            es.ListVehicles();
            break;

        case "4":
            displayMenu = false;
            break;

        default:
            Console.WriteLine("Invalid Option");
            break;
    }

    Console.WriteLine("Press a key to continue");
    Console.ReadLine();
}

Console.WriteLine("The program ended");
