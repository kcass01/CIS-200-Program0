using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    //address class to hold address objects.
    class Address
    {
        //backing fields for the various properties
        private string _name;
        private string _addressLine1;
        private string _addressLine2;
        private string _city;
        private string _state;
        private int _zip;

        //field variable to hold default zip value, private
        private static int DEFAULTZIP = 40208;
        //field variable to hold the default name
        private static string DEFAULTNAME = "Current Resident";
        //field variable for default city
        private static string DEFAULTCITY = "Louisville";
        //field for default state
        private static string DEFAULTSTATE = "Kentucky";
        //field for defaults address line
        private static string DEFAULTLINE1 = "45 Default Street";

        //the constructor for two address lines
        public Address(string name, string addressLine1, string addressLine2, 
            string city, string state, int zip)
        {
            Name = name;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            State = state;
            Zip = zip;
        }

        //overloaded constructor for no address line 2
        public Address(string name, string addressLine1, string city, string state, int zip)
        {
            Name = name;
            AddressLine1 = addressLine1;
            City = city;
            State = state;
            Zip = zip;
        }

        //name property
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                //makes sure set value is not empty or otherwise useless
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                //defaults to current resident with lack of name
                else
                {
                    _name = DEFAULTNAME;
                }
            }
        }

        //Zip Code property
        public int Zip
        {
            get
            {
                return _zip;
            }
            set
            {
                //makes sure zip is in the correct range
                if(value >= 0 && value <= 99999)
                {
                    _zip = value;
                }
                //if not, defaults to zero
                else
                {
                    _zip = DEFAULTZIP;
                }
            }
        }

        //address line one property
        public string AddressLine1
        {
            get
            {
                return _addressLine1;
            }
            //makes sure address line one has a valid value
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _addressLine1 = value;
                }
                //if not, set to defaults
                else
                {
                    _addressLine1 = DEFAULTLINE1;
                }
            }
        }

        //address line two property
        public string AddressLine2
        {
            get
            {
                return _addressLine2;
            }
            //no validation for line 2, since it may very well be empty
            set
            {
                _addressLine2 = value;
            }
        }

        //city property
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                //makes sure city contains a valid value
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _city = value;
                }
                //if not, set to defaults
                else
                {
                    _city = DEFAULTCITY;
                }
            }
        }

        //state property
        public string State
        {
            get
            {
                return _state;
            }
            //makes sure state has a valid value
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _state = value;
                }
                //if not, set to defaults
                else
                {
                    _state = DEFAULTSTATE;
                }
            }
        }

        //overridden tostring to format output how we want
        //precondition: none
        //postcondition: returns formatted string for address
        public override string ToString()
        {
            //string to simplify new line creation
            string nl = System.Environment.NewLine;
            //string to hold potential address 2
            string addressLine2 = "";

            //checks if address line two has any meaningful data
            if (!String.IsNullOrWhiteSpace(AddressLine2))
            {
                addressLine2 = "Address Line 2: " + AddressLine2 + nl;
            }
            return "Name: " + Name + nl + "Address Line 1: " + AddressLine1 + nl + addressLine2 
                + "City: " + City+ nl + "State: " + State + nl + 
                "Zip Code: " + Zip.ToString("D5");
        }
    }
}
