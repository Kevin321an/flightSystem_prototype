using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{   /// <summary>
/// define the flight information
/// </summary>
    public class Flight
    {
        private Route route;

        public Route Route
        {
            get { return route; }
            set { route = value; }
        }
        private string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        
        private DateTime departureTime;
        /// <summary>
        /// departureTime
        /// </summary>
        public DateTime DepartureTime
        {
            get { return departureTime; }
            set { departureTime = value; }
        }
        private DateTime arrivalTime;
        /// <summary>
        /// arrivale time
        /// </summary>
        public DateTime ArrivalTime
        {
            get { return arrivalTime; }
            set { arrivalTime = value; }
        }
        /// <summary>
        /// the time of fight would spend
        /// </summary>
        /// <param name="arrivalTime">arrival time </param>
        /// <param name="departureTime"><departureTime/param>
        /// <returns></returns>
        public TimeSpan Duration(DateTime arrivalTime, DateTime departureTime)
        {
            return arrivalTime - departureTime;
        }

        public Flight()
        {
            
        }

        public void Update(Flight flight)
        {
           
        }

        public void Delete(Flight flight)
        {
           
        }

        public Flight View()
        {
            return this;
        }
    }
}
