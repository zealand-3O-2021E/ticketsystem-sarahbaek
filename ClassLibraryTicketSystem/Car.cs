﻿using System;

namespace ClassLibraryTicketSystem
{
    public class Car : Vehicle
    {
        /// <summary>
        /// Empty Constructor
        /// </summary>
        public Car()
        {

        }
        /// <summary>
        /// Overloaded Constructor with 2 parameters licenceplate and date
        /// </summary>
        /// <param name="licencePlate"></param>
        /// <param name="date"></param>
        public Car(string licencePlate, DateTime date)
        : base(licencePlate, date)
        {

        }
        /// <summary>
        /// Overloaded Constructor with 3 parameters- licenceplate, date and brobizz
        /// </summary>
        /// <param name="licencePlate"></param>
        /// <param name="date"></param>
        /// <param name="broBizz"></param>
        public Car(string licencePlate, DateTime date, bool broBizz)
        : base(licencePlate, date, broBizz)
        {

        }

        /// <summary>
        /// Overloaded Constructor with 4 parameters
        /// </summary>
        /// <param name="licencePlate"></param>
        /// <param name="date"></param>
        /// <param name="broBizz"></param>
        /// <param name="bridgeName"></param>
        public Car(string licencePlate, DateTime date, bool broBizz, string bridgeName)
          : base(licencePlate, date, broBizz, bridgeName)
        {

        }

    }
}
