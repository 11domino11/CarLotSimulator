using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car hondaAccord09 = new Car(2009, "Honda", "Accord", "vroom", "honk", true);
            Console.WriteLine($"{hondaAccord09.Year} {hondaAccord09.Make} {hondaAccord09.Model} {hondaAccord09.EngineNoise} {hondaAccord09.HonkNoise} {hondaAccord09.IsDriveable}");

            Car buickRegal98 = new Car()
            {
                Year = 1998,
                Make = "Buick",
                Model = "Regal",
                EngineNoise = "Purt",
                HonkNoise = "--",
                IsDriveable = false
            };
            Console.WriteLine($"{buickRegal98.Year} {buickRegal98.Make} {buickRegal98.Model} {buickRegal98.EngineNoise} {buickRegal98.HonkNoise} {buickRegal98.IsDriveable}");

            Car FordFocus12 = new Car();
            FordFocus12.Year = 2012;
            FordFocus12.Make = "Ford";
            FordFocus12.Model = "Focus";
            FordFocus12.EngineNoise = "Meeeeww";
            FordFocus12.HonkNoise="meep";
            FordFocus12.IsDriveable = true;
            Console.WriteLine($"{FordFocus12.Year} {FordFocus12.Make} {FordFocus12.Model} {FordFocus12.EngineNoise} {FordFocus12.HonkNoise} {FordFocus12.IsDriveable}");
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
