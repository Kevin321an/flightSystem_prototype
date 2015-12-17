using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    public class TicketType
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

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private int timeLimitRefund;

        public int TimeLimitRefund
        {
            get { return timeLimitRefund; }
            set { timeLimitRefund = value; }
        }
    }
}
