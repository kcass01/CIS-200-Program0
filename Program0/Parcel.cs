using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    //abstract parcel class to serve as basis for mailable objects
    abstract class Parcel
    {
        //Backing variables to hold the address information
        private Address _originAddress;
        private Address _destinationAddress;

        //constructor to create the parcel object
        public Parcel(Address originAddress, Address destinationAddress)
        {
            OriginAddress = originAddress;
            DestinationAddress = destinationAddress;
        }

        //Origin address property
        public Address OriginAddress
        {
            get
            {
                return _originAddress;
            }
            //no validation since all address data already validated.
            set
            {
                _originAddress = value;
            }
        }

        //destination address property
        public Address DestinationAddress
        {
            get
            {
                return _destinationAddress;
            }
            //no validation since all data should be valid for an address to exist
            set
            {
                _destinationAddress = value;
            }
        }

        //method to calculate cost; abstract for now
        //no preconditions, postcondition is a variable cost.
        public abstract decimal CalcCost();

        //tostring override method to return values of data fields as strings
        //displays costs and fees
        //preconditions: none
        //postconditions: a formatted string for the output
        public override string ToString()
        {
            //simplified newline
            string nl = Environment.NewLine;
            return "Origin Address:" + nl + OriginAddress.ToString() + nl + nl 
                + "Destination Address:" + nl + DestinationAddress.ToString()
                 + nl + "Cost: " + CalcCost().ToString("C");
        }
    }
}
