﻿using System;

namespace DEV_2._1
{
    class AddCarCommand : ICommand
    {
        private CarShop Shop;

        /// <summary>
        /// This Command asks to set a car and then add it in warehouse
        /// </summary>
        public AddCarCommand(CarShop receiver)
        {
            this.Shop = receiver;
        }

        public void Execute()
        {
            Console.Write("Input serial number: ");
            string serialNumber = Console.ReadLine();
            Console.Write("Input brand Id: ");
            string brandId = Console.ReadLine();
            Console.Write("Input model Id: ");
            string modelId = Console.ReadLine();            
            Console.Write("Set price: ");
            Double.TryParse(Console.ReadLine(), out double price);

            this.Shop.AddCarToWarehouse(new SerializableCar(serialNumber, brandId, modelId, price));
        }
    }
}