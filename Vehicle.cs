﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_PrateekChadha
{
    public class Vehicle
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public double RentalPrice { get; set; }

        public Vehicle(string model, string manufacturer, int year, double rentalPrice)
        {
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            RentalPrice = rentalPrice;
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Model: {Model}, Manufacturer: {Manufacturer}, Year: {Year}, Rental Price: {RentalPrice}");
        }
    }

}
