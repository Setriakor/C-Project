using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class SilverApartment : Apartment
    {
        public SilverApartment(int floorNumber, int doorNumber, string residentName) :
            base(floorNumber, doorNumber, residentName)
        {
        }

        public override void ringDoorbell()
        {
            double val = new Random().NextDouble();
            if (val > 0.2)
            {
                Console.WriteLine("Hello");
            }
        }
    }
}
