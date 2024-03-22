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
            
            Car car1 = new Car("Supra Mark iv", "Toyota", 2005, 50.0, 5, "Gasoline", "Manual", false);
            Truck truck1 = new Truck("Bronco", "Ford", 2010, 80.0, 4, "Pickup", true);
            Motorcycle motorcycle1 = new Motorcycle("H2R", "Kawasaki", 2020, 30.0, 1000, "Gasoline", true);

            
            RentalAgency agency = new RentalAgency(10);

            
            agency.AddVehicle(car1);
            agency.AddVehicle(truck1);
            agency.AddVehicle(motorcycle1);

            foreach (var vehicle in agency.Fleet)
            {
                if (vehicle != null)
                {
                    vehicle.DisplayDetails();
                }
            }
            
            agency.RentVehicle("Supra Mark iv", 3);

            
            agency.RemoveVehicle("Bronco");

            
            Console.WriteLine($"Total Revenue: {agency.TotalRevenue}");
        }
    }
    }