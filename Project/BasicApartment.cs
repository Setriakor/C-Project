using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class BasicApartment: Apartment
    {
        public BasicApartment(int floorNumber, int doorNumber, string residentName) :
            base(floorNumber, doorNumber, residentName)
        {
        }

        public override void ringDoorbell()
        {
            double val = new Random().NextDouble();
            if (val > 0.9)
            {
                Console.WriteLine("Hello");
            }
        }
    }
}
