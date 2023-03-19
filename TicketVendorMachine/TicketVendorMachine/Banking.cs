using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketVendorMachine
{
    class Banking
    {
        private string IDCard;
        private string pinCode;

        public Banking() { }

        public Banking(string iDCard, string pinCode)
        {
            IDCard1 = iDCard;
            this.PinCode = pinCode;
        }

        public string IDCard1 { get => IDCard; set => IDCard = value; }
        public string PinCode { get => pinCode; set => pinCode = value; }

        public string toString()
        {
            return IDCard + " - " + pinCode;
        }
    }
}
