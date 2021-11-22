using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    class FirstClassPassenger: EconomyPassenger
    {
        double bonus;
        List<string> menu = new List<string>();

        public FirstClassPassenger(double id, string forename, string surname, string phonenumber, double luggageWeight, List<Ticket> ticketList)
                            : base(id, forename, surname, phonenumber, luggageWeight, ticketList)
        {
            menu.Add("Honey and Garlic Roast Duck");
            menu.Add("Roasted skate wing with charred leeks and samphire");
            menu.Add("Garlic Bread");

            foreach (Ticket ticket in ticketList)
            {
                if(ticket.GetPassengerId() == id) {
                    this.bonus = bonus + ticket.GetPrice() * 0.02;
                }
            }
            bonus = Math.Round(bonus,2);
        }

        override public string GetInfo()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat(base.GetInfo() + ", ");
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
