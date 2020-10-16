using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class GrandApartment : Apartment
    {

        public GrandApartment(int floorNumber, string doorNumber) :
            base(floorNumber, doorNumber)
        { 
        }

        public GrandApartment(int floorNumber, string doorNumber,string residentName):
            base(floorNumber,doorNumber,residentName)
        {
        }

        public override string ringDoorbell()
        {
            //Console.WriteLine("Hello");
            return "Hello";
        }
    }
}
