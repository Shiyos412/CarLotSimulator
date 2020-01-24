using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO - DONE

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            CarLot lot = new CarLot();
            Car sporty = new Car() { EngineNoise = "Vroom", Year = 2009, HonkNoise = "Honk", IsDriveable = true, Make = "Ford", Model = "Mustang" };
            Car truck = new Car();
            truck.EngineNoise = "Vroooom";
            truck.HonkNoise = "Bonk";
            truck.Make = "Ford";
            truck.Model = "F150";
            truck.IsDriveable = true;
            truck.Year = 2015;
            var sedan = new Car();
            sedan.EngineNoise = "Vrom";
            sedan.HonkNoise = "Beep";
            sedan.Model = "Civic";
            sedan.Make = "Honda";
            sedan.IsDriveable = true;
            sedan.Year = 1998;
            Car.MakeEngineNoise(sedan.EngineNoise);
            Car.MakeHonkNoise(sedan.HonkNoise);
            Car.MakeHonkNoise(truck.HonkNoise);
            Car.MakeHonkNoise(sporty.HonkNoise);
            Car.MakeEngineNoise(sporty.EngineNoise);
            Car.MakeEngineNoise(truck.EngineNoise);
            lot.Cars.Add(sporty);
            lot.Cars.Add(sedan);
            lot.Cars.Add(truck);
            foreach(Car a in lot.Cars)
            {
                Console.WriteLine($"Year: {a.Year}\nMake: {a.Make}\nModel: {a.Model}");
            }
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
