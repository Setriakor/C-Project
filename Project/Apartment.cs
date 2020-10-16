using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    abstract class Apartment
    {
        int floorNumber,doorNumber;
        string residentName;
        bool doorbell;

        protected Apartment(int floorNumber, int doorNumber, string residentName)
        {
            this.floorNumber = floorNumber;
            this.doorNumber = doorNumber;
            this.residentName = residentName;
            this.doorbell = false;
        }

        public int FloorNumber { get => floorNumber; set => floorNumber = value; }
        public int DoorNumber { get => doorNumber; set => doorNumber = value; }
        public string ResidentName { get => residentName; set => residentName = value; }

        public abstract void ringDoorbell(); 
        
    }
}
