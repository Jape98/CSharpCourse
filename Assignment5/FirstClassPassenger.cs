using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class FirstClassPassenger: EconomyPassenger
    {
        double luggageWeight;
        double bonus;
        List<string> menu;

        public FirstClassPassenger(double id, string forename, string surname, string phonenumber, double luggageWeight)
                            : base(id, forename, surname, phonenumber, luggageWeight)
        {
            menu.Add("Honey and Garlic Roast Duck, Austrian wiener schnitzel");
            menu.Add("Roasted skate wing with charred leeks and samphire, Blueberry financiers");
            menu.Add("Garlic Bread");
        }
    }
}
