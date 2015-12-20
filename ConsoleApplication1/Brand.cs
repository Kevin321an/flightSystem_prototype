using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    /// <summary>
    /// The Brand class
    /// </summary>
    public class Brand
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string description;
        /// <summary>
        /// description
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public Brand()
        {
           
        }
        /// <summary>
        /// delete the brand
        /// </summary>
        /// <param name="brand"></param>
        public void Delete(Brand brand)
        {
            
        }
        /// <summary>
        /// update the brand
        /// </summary>
        /// <param name="brand"></param>
        public void Update(Brand brand)
        {
            
        }
        /// <summary>
        /// view the brand
        /// </summary>
        /// <returns></returns>
        public Brand View()
        {
            return this;
        }
    }
}
