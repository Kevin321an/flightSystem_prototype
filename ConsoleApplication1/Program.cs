using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
      

            /// <summary>
            /// The main thread of this program. In this example, this part is use to get some result to test the code
            /// </summary>
            /// <param name="args">input string arry to the programe</param>
            static void Main(string[] args)
        {

                // Create Flight flight and attach it to different customer groups        
                ///test the observer pattern:
                FlightTicket discount = new FlightTicket("AC032", 120.00);
                discount.Attach(new RegisteredUser("CommonUser"));
                discount.Attach(new SilverUser("SilverUser"));
                discount.Attach(new GoldenUser("GoldenUser"));
                // Altering prices will notify customer groups
                discount.Price = 2000.10;
                discount.Price = 3000.00;
                discount.Price = 40000.50;
                discount.Price = 60000.75;
                // Wait for input to end the programe
                Console.ReadKey();
            }
        }
    
}
