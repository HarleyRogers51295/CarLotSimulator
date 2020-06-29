using System;
using System.Collections.Generic;
using System.Threading;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //DONE: Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            CarLot carLot = new CarLot(); 
            
            


            Car redCar = new Car(1995, "Jeep", "Grand Cherokee", "vroom vroom", "Beep Beep!", true);
            CarLot.CarList.Add(redCar);//adding car to the list
            Car blueCar = new Car(2005, "Ford", "F150", "VRUMMMMMMMM!", "Doot Doot!", false);
            Car blackCar = new Car(2020, "Tesle", "Mark3", "*krickits*", "squeek squeek!", false);

            Console.WriteLine("Here is the red cars stats!");
            Console.WriteLine($"{redCar.Year}, {redCar.Make}, {redCar.Model}, {redCar.IsDriveable}");
            Console.WriteLine("This cars engine goes!");
            Car.MakeEngineNoise(redCar.EngineNoise);
            Console.WriteLine("This cars horn goes!");
            Car.MakeHonkNoise(redCar.HonkNoise);
            Console.WriteLine("Press any key to see the next car!");
            Console.ReadLine();

            Console.WriteLine("Here is the blue cars stats!");
            Console.WriteLine($"{blueCar.Year}, {blueCar.Make}, {blueCar.Model}, {blueCar.IsDriveable}");
            Console.WriteLine("This cars engine goes!");
            Car.MakeEngineNoise(blueCar.EngineNoise);
            Console.WriteLine("This cars horn goes!");
            Car.MakeHonkNoise(blueCar.HonkNoise);
            Console.WriteLine("Press any key to see the next car!");
            Console.ReadLine();

            Console.WriteLine("Here is the black cars stats!");
            Console.WriteLine($"{blackCar.Year}, {blackCar.Make}, {blackCar.Model}, {blackCar.IsDriveable}");
            Console.WriteLine("This cars engine goes!");
            Car.MakeEngineNoise(blackCar.EngineNoise);
            Console.WriteLine("This cars horn goes!");
            Car.MakeHonkNoise(blackCar.HonkNoise);
            Console.WriteLine("Press any key to see the next car!");
            Console.ReadLine();

            foreach(Car car in CarLot.CarList)
            {
                Console.WriteLine($"Red Car stats: Year = {car.Year}, make = {car.Make}, model = {car.Model}");
                
            }




            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car?????

            Car car1 = new Car(); //method 1, long method
            car1.Year = 1995;
            car1.Make = "Jeep";
            car1.Model = "Cherokee";
            car1.EngineNoise = "vvvooommm!";
            car1.HonkNoise = "Bloop!";
            car1.IsDriveable = true;

            var car2 = new Car()//method 2
            {
                Year = 1995,
                Make = "Jeep",
                Model = "Cherokee",
                EngineNoise = "vroomie",
                HonkNoise = "pooooot",
                IsDriveable = false,
            };

            Car car3 = new Car(2020, "Tesle", "Mark3", "*krickits*", "squeek", false);//method 3. best way.


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
