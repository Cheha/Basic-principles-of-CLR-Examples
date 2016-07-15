using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_10._6_Null_coalesce_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int? ticketsOnSale = null;

            int availableTickets;

            if (ticketsOnSale == null)
            {
                availableTickets = 0;
            }
            else {
                // availableTickets = ticketsOnSale; error
                availableTickets = ticketsOnSale.Value;
                availableTickets = (int)ticketsOnSale;
            }

            Console.WriteLine("Available tickets: {0}", availableTickets);
        }
    }
}
