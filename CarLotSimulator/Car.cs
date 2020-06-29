using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Car
    {
         //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model{ get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public Car() { /*defualt constructor.*/ }
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable)
        {
            this.Year = year;
            this.Make = make;
            this.Model = model;
            this.EngineNoise = engineNoise;
            this.HonkNoise = honkNoise;
            this.IsDriveable = isDrivable;
            

        }

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property

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
