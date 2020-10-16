using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class BasicApartment: Apartment
    {
        public BasicApartment(int floorNumber, string doorNumber) :
            base(floorNumber, doorNumber)
        {
        }

        public BasicApartment(int floorNumber, string doorNumber, string residentName) :
            base(floorNumber, doorNumber, residentName)
        {
        }

        public override string ringDoorbell()
        {
            double val = new Random().NextDouble();
            if (val < 0.1)
            {
                throw new NobodyHomeException("Nobody is home");
            }
            return "Hello";
        }
    }
}
