using System;
using System.Collections.Generic;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Apartment[,] aps = new Apartment[12, 6];
            
            TurntablTowers tower = new TurntablTowers(aps);

            while (true)
            {
                int floor = new Random().Next(12);
                int num = new Random().Next(6);
                tower.GetApartment(floor, num).call();
                System.Threading.Thread.Sleep(1000);
            }


        }
    }
}
