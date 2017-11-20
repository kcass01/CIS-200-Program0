using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    //this class covers the letter, a child class of the parcel object.
    class Letter : Parcel
    {
        //backing field for fixed cost
        private decimal _fixedCost;
        //constructor, will inherit addresses from the base constructor
        public Letter (Address originAddress, Address destinationAddress, decimal fixedCost)
            : base (originAddress, destinationAddress)
        {
            FixedCost = fixedCost;
            OriginAddress = originAddress;
            DestinationAddress = destinationAddress;
        }

        //property for the fixed cost
        protected decimal FixedCost
        {
            get
            {
                return _fixedCost;
            }
            set
            {
                //makes sure the letter has a cost or zero value if free
                if(value >= 0)
                {
                    _fixedCost = value;
                }
                //defaults to zero if this is not the case
                else
                {
                    _fixedCost = 0;
                }
            }
        }

        //the calccost method is given definition here
        //preconditions: none
        //postconditions: returns the decimal of the cost
        public override decimal CalcCost()
        {
            return _fixedCost;
        }

        //overridden tostring to give a more accurate readout
        //preconditions: none
        //postconditions: returns the formatted tostring for the letter object
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
