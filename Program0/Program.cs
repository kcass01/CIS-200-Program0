//Grading ID: D7010
//CIS 200-76
//Program 0
//This program uses is a and has a relationships to creates letters with addresses.
//It then creates simple example cases to test the classes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    class Program
    {
        static void Main(string[] args)
        {
            //List to hold the letter objects
            List<Parcel> parcelHolder = new List<Parcel>();
            //creates 4 unique address to use for destination or origin.
            Address louisvilleAddress = new Address("John Brown", "341 East Road", "Louisville", "Kentucky", 40208);
            Address northernKentuckyAddress = new Address("Nolan Johnson","54 Frog Street","Independence","Kentucky",41051);
            Address indianaAddress = new Address("Beverly Jack", "123 Apple Road", "New Albany","Indiana",47150);
            Address cincinnatiAddress = new Address("Mike Lewis", "672 Main Street", "Apartment 23", "Cincinnati", "Ohio", 41073);

            //creates 4 letter objects to be sent and stored
            Letter letterOne = new Letter(louisvilleAddress, northernKentuckyAddress, (decimal)2.57);
            Letter letterTwo = new Letter(cincinnatiAddress, louisvilleAddress, (decimal)3.24);
            Letter letterThree = new Letter(indianaAddress,louisvilleAddress,(decimal)1.56);
            Letter letterFour = new Letter(northernKentuckyAddress, indianaAddress, (decimal)3.11);
            //adds all 4 letters to a list
            parcelHolder.Add(letterOne);
            parcelHolder.Add(letterTwo);
            parcelHolder.Add(letterThree);
            parcelHolder.Add(letterFour);

            //foreach loop to write to the console the tostring for each item in the list
            foreach(Parcel example in parcelHolder)
            {
                Console.WriteLine(example.ToString());
                //creates a 2 line gap between entries for readability
                Console.WriteLine(System.Environment.NewLine);
            }
        }
    }
}
