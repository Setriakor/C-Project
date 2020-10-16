using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class SilverApartment : Apartment
    {
        public SilverApartment(int floorNumber, string doorNumber) :
            base(floorNumber, doorNumber)
        {
        }

        public SilverApartment(int floorNumber, string doorNumber, string residentName) :
            base(floorNumber, doorNumber, residentName)
        {
        }

        public override string ringDoorbell()
        {
            double val = new Random().NextDouble();
            if (val < 0.8)
            {
                throw new NobodyHomeException("Nobody is home");
            }
            return "Hello";
        }
    }
}
