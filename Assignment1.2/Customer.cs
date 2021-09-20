using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_I_II
{
    class Customer
    {
        int id;
        string name;
        public List<int> flightID;

        public Customer(int id, string name, List<int> flightID)
        {
            this.id = id;
            this.name = name;
            this.flightID = flightID;

        }

        public bool SearchCustomer(int id)
        {
            if (this.id == id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {

            string result = string.Join(", ", flightID.ToArray());

            return id + "  ->  " + " Customer name: " + name + ", Flight ids: " + result;
        }
    }
}
