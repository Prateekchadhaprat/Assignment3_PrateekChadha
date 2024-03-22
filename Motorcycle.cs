﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_PrateekChadha
{
    public class Motorcycle : Vehicle
    {
        // Additional properties for Motorcycle
        public int EngineCapacity { get; set; }
        public string FuelType { get; set; }
        public bool HasFairing { get; set; }
        public Motorcycle(string model, string manufacturer, int year, double rentalPrice,
                      int engineCapacity, string fuelType, bool hasFairing)
        : base(model, manufacturer, year, rentalPrice)
        {
            EngineCapacity = engineCapacity;
            FuelType = fuelType;
            HasFairing = hasFairing;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Engine Capacity: {EngineCapacity}, Fuel Type: {FuelType}, Has Fairing: {HasFairing}");
        }

    }
}
