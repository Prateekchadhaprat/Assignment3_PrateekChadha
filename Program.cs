using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_PrateekChadha
{
    class Program
    {
        static void Main(string[] args) 
        {
            
            Car car1 = new Car("Supra Mark iv", "Toyota", 2005, 50.0, 5, "Gasoline", "Manual", false); // Created instances of different vehicles
            Truck truck1 = new Truck("Bronco", "Ford", 2010, 80.0, 4, "Pickup", true);
            Motorcycle motorcycle1 = new Motorcycle("H2R", "Kawasaki", 2020, 30.0, 1000, "Gasoline", true);

            
            RentalAgency agency = new RentalAgency(10); // Created rental agency


            agency.AddVehicle(car1); // Adding vehicles to the agency's fleet
            agency.AddVehicle(truck1);
            agency.AddVehicle(motorcycle1);

            

            foreach (var vehicle in agency.Fleet) // Displaying details of each vehicle in the fleet
            {
                if (vehicle != null)
                {
                    vehicle.DisplayDetails();
                }
            }
            
            agency.RentVehicle("Supra Mark iv", 3); // this will Rent a vehicle


            agency.RemoveVehicle("Bronco");// Removing a vehicle from the fleet


            Console.WriteLine($"Total Revenue: {agency.TotalRevenue}");// It will Display the total revenue of the agency
        }
    }
    }