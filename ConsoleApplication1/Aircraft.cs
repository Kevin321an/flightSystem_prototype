using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    /// <summary>
    /// The Aircraftclass
    /// </summary>   
    public class Aircraft
    {

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string manufacture;

        public string Manufacture
        {
            get { return manufacture; }
            set { manufacture = value; }
        }
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private Brand brand;

        public Brand Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public Aircraft()
        {
            
        }

        public Aircraft ViewAircraft()
        {
            return this;
        }

        public void Delete(Aircraft aircraft)
        {
            
        }

        public void Update(Aircraft aircraft)
        {
            
        }
    }
}
