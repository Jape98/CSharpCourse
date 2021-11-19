using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class EconomyPassenger: Passenger
    {
        double luggageWeight;
        public EconomyPassenger(double id, string forename, string surname, string phonenumber, double luggageWeight)
                          :base(id, forename, surname, phonenumber)
        {
            luggageWeight = this.luggageWeight;
        }
    }
}
