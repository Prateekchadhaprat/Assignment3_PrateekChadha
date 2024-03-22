using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_PrateekChadha
{
    public class RentalAgency
    {
        
        private Vehicle[] Fleet;
        private int count;
        
        public double TotalRevenue { get; private set; }

        public RentalAgency(int capacity)
        {
            Fleet = new Vehicle[capacity];
            count = 0;
            TotalRevenue = 0;
        }
        public void AddVehicle(Vehicle vehicle)
        {
            if (count < Fleet.Length)
            {
                Fleet[count++] = vehicle;
            }
            else
            {
                Console.WriteLine("Fleet is full. Cannot add more vehicles.");
            }
        }

        public void RemoveVehicle(string model)
        {
            for (int i = 0; i < count; i++)
            {
                if (Fleet[i].Model == model)
                {
                    Fleet[i] = null;
                    for (int j = i; j < count - 1; j++)
                    {
                        Fleet[j] = Fleet[j + 1];
                    }
                    count--;
                    Console.WriteLine($"Vehicle {model} removed from the fleet.");
                    return;
                }
            }
            Console.WriteLine($"Vehicle {model} not found in the fleet.");
        }
        public void RentVehicle(string model, int days)
        {
            for (int i = 0; i < count; i++)
            {
                if (Fleet[i].Model == model)
                {
                    double rentalPrice = Fleet[i].RentalPrice * days;
                    TotalRevenue += rentalPrice;
                    Console.WriteLine($"Vehicle {model} rented for {days} days. Total price: {rentalPrice}");
                    return;
                }
            }
            Console.WriteLine($"Vehicle {model} not found in the fleet.");
        }
    }
}
    }
