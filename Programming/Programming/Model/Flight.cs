﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model
{
    public class Flight
    {
        private string _departurePoint;

        private string _destinationPoint;

        private int _flightTime;

        public Flight()
        {

        }

        public Flight(string departurePoint, string destinationPoint, int flightTime)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTime = flightTime;
        }

        public string DeparturePoint { get; set; }

        public string DestinationPoint { get; set; }

        public int FlightTime
        {
            get
            {
                return _flightTime;
            }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException("Время полета не может быть отрицательным");
                }
                _flightTime = value;
            }
        }
    }

   
}
