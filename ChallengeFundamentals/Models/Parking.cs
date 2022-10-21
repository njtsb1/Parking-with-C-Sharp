namespace ChallengeFundamentals.Models
{
    public class Parking
    {
        private decimal initialPrice = 0;
        private decimal pricePerHour = 0;
        private List<string> vehicles = new List<string>();

        public Parking(decimal initialPrice, decimal pricePerHour)
        {
            this.initialPrice = initialPrice;
            this.pricePerHour = pricePerHour;
        }

        public void AddVehicle()
        {
            // Ask the user to enter a plate (ReadLine) and add to list "vehicles"
            Console.WriteLine("Enter vehicle license plate to park:");
            vehicles.Add(Console.ReadLine());
        }

        public void RemoveVehicle()
        {
            Console.WriteLine("Enter vehicle license plate to remove:");

            // Ask the user to type the license plate and store it in the license plate variable
            string plate = Console.ReadLine();

            // Check if the vehicle exists
            if (vehicles.Any(x => x.ToUpper() == plate.ToUpper()))
            {
                Console.WriteLine("Enter the number of hours the vehicle was parked:");
                // Ask the user to enter the number of hours the vehicle was parked,
                // Perform the following calculation: "initialPrice + pricePerHour * hours" for the variable amount
                int hours = 0;
                decimal amount = 0; 
                hours = Convert.ToInt32(Console.ReadLine());
                amount = initialPrice + pricePerHour * hours;
                vehicles.Remove(plate);
                // Remove typed plate from vehicle list
                Console.WriteLine($"The vehicle {plate} was removed and the total price was: R$ {amount}");
            }
            else
            {
                Console.WriteLine("Sorry, that vehicle is not parked here. Check if you typed the plate correctly");
            }
        }

        public void Listarvehicles()
        {
            // Checks for vehicles in the parking lot Parking
            if (vehicles.Any())
            {
                Console.WriteLine("Parked vehicles are:");
                // Perform a repeat loop, displaying parked vehicles
                foreach (var vehicle in vehicles)
                {
                    Console.WriteLine(vehicle.ToString());
                }
            }
            else
            {
                Console.WriteLine("There are no parked vehicles.");
            }
        }
    }
}
