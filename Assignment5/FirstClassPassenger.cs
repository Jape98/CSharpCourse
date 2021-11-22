using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class FirstClassPassenger: EconomyPassenger
    {
        double bonus;
        List<string> menu;

        public FirstClassPassenger(double id, string forename, string surname, string phonenumber, List<Ticket> ticketList, double luggageWeight)
                            : base(id, forename, surname, phonenumber, ticketList, luggageWeight)
        {
            menu = new List<string>();
            menu.Add("Honey and Garlic Roast Duck");
            menu.Add("Roasted skate wing with charred leeks and samphire");
            menu.Add("Garlic Bread");

            foreach (Ticket ticket in ticketList)
            {
                this.bonus = bonus + ticket.GetPrice() * 0.02;
            }
            bonus = Math.Round(bonus,2);
        }

        override public string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat(base.ToString() + ", ");
            str.AppendFormat("\nBonus: " + bonus + "%, ");
            str.AppendFormat("\nAvailable Meals: ");
            foreach (string s in menu)
            {
                str.AppendFormat("\n"+s);
            }
            
            return str.ToString();
        }
    }
}
