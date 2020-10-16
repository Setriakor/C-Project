using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    abstract class Apartment
    {
        int floorNumber;
        string doorNumber, residentName;
        bool doorbell;

        protected Apartment(int floorNumber, string doorNumber, string residentName)
        {
            this.floorNumber = floorNumber;
            this.doorNumber = doorNumber;
            this.residentName = residentName;
            this.doorbell = false;
        }

        public int FloorNumber { get => floorNumber; set => floorNumber = value; }
        public string DoorNumber { get => doorNumber; set => doorNumber = value; }
        public string ResidentName { get => residentName; set => residentName = value; }

        public abstract void ringDoorbell(); 
        
    }
}
