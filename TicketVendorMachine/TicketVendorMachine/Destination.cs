

namespace TicketVendorMachine
{
    class Destination
    {
        private string time;
        private string location;
        private string price;

        public Destination() { }
        public Destination(string time, string location, string price)
        {
            this.Time = time;
            this.Location = location;
            this.Price = price;
        }

        public string Time { get => time; set => time = value; }
        public string Location { get => location; set => location = value; }
        public string Price { get => price; set => price = value; }
        
        public string toString()
        {
            return this.time + " - " + this.location + " - " + this.price;
        }
    }
}
