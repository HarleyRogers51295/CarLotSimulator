using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Car
    {
        
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model{ get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public Car() 
        {
            CarLot._numberOfCars++; //This increments the static field in CarLot
        }
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable)
        {
            this.Year = year;
            this.Make = make;
            this.Model = model;
            this.EngineNoise = engineNoise;
            this.HonkNoise = honkNoise;
            this.IsDriveable = isDrivable;
            CarLot._numberOfCars++;// Need to do it in both!

        }

        
        public static void MakeEngineNoise(string engineNoises)
        {
           Console.WriteLine(engineNoises);
        }
        public static void MakeHonkNoise(string honkNoises)
        {
            Console.WriteLine(honkNoises);
        }
         

    }
}
