﻿using System;
using System.Text;

namespace CW_3
{
    public class Truck : Vehicle
    {
        public Engine Engine { get; set; }
        public Chassis Chassis { get; private set; }
        public Transmission Transmission { get; private set; }

        private double _carryingMass;
        public double CarryingMass
        {
            get
            {
                return _carryingMass;
            }
            set
            {
                if (value > 0)
                {
                    _carryingMass = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        private double _height;
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        private double _width;
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        /// <summary>
        /// Hardcode creation of the truck
        /// </summary>
        public Truck(Chassis chassis, Transmission transmission, double width, double height)
        {
            this.Chassis = chassis;
            this.Transmission = transmission;
            this.Height = 3.8;
            this.Width = 3.5;
        }

        /// <summary>
        /// Returns all information about this truck as a string
        /// </summary>
        public override string GetInfo()
        {
            StringBuilder info = new StringBuilder($"Object: truck");
            info.Append($"\nmodel: {Model}");
            info.Append($"\nserial number: {SerialNumber}");
            info.Append($"\nuseful volume: {CarryingMass}");
            info.Append($"\nheight: {Height}");
            info.Append($"\nwidth: {Width}");
            info.Append($"\n{this.Engine.GetInfo()}");
            info.Append($"\n{this.Chassis.GetInfo()}");
            info.Append($"\n{this.Transmission.GetInfo()}");

            return info.ToString();
        }
    }
}