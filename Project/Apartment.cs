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
        public event EventHandler<string> intercom;


        protected Apartment(int floorNumber, string doorNumber)
        {
            this.floorNumber = floorNumber;
            this.doorNumber = doorNumber;
            this.doorbell = false;
        }

        protected Apartment(int floorNumber, string doorNumber,string residentName)
        {
            this.floorNumber = floorNumber;
            this.doorNumber = doorNumber;
            this.doorbell = false;
            this.residentName = residentName;
        }

        public int FloorNumber { get => floorNumber; set => floorNumber = value; }
        public string DoorNumber { get => doorNumber; set => doorNumber = value; }
        public string ResidentName { get => residentName; set => residentName = value; }

        public abstract string ringDoorbell();

        public override string ToString()
        {
            return "Apartment " + doorNumber + ": " + residentName;
        }

        protected virtual void OnIntercom(string e)
        {
            EventHandler<string> handler = intercom;
            if(handler !=null)
            {
                handler(this, e);
            }
        }

        public void call()
        {
            OnIntercom(residentName);
        }
    }
}
