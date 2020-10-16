using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class TurntablTowers
    {
        static int numFloors = 12;
        static int numApartments = 6;
        Apartment[,] floors = new Apartment[numFloors, numApartments];
        
        public TurntablTowers(Apartment[,] apartments) 
        {
            for (int i = 0; i < numFloors; i++)
            {
                for (int j = 0; j < numApartments; j++)
                {
                    string doorNumber = i + "-" + j;
                    switch (i)
                    {
                        case int n when (i < 4):
                            floors[i, j] = new BasicApartment(i, doorNumber,"RandomRes "+doorNumber);
                            break;
                        case int n when (i < 8):
                            floors[i, j] = new SilverApartment(i, doorNumber, "RandomRes " + doorNumber);
                            break;
                        case int n when (i < 12):
                            floors[i, j] = new GrandApartment(i, doorNumber, "RandomRes " + doorNumber);
                            break;
                    }
                    floors[i, j].intercom += ConciergeDesk;
                }
            }
        }

        public void takeTheRegister()
        {
            foreach (Apartment apartment in floors)
            {
                Console.WriteLine(apartment);
            }
        }

        public void ringAllDoorbells()
        {
            foreach (Apartment apartment in floors)
            {
                try
                {
                    apartment.ringDoorbell();
                }
                catch (NobodyHomeException ex)
                {
                    Console.WriteLine(apartment + " did not answer the doorbell");
                }
            }
        }

        public Apartment GetApartment(int i, int j)
        {
            return floors[i, j];
        }

        static void ConciergeDesk(object sender, String e)
        {
            Console.WriteLine("Resident {0} called", e);
        }

    }
}
