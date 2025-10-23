/*
    https://learn.microsoft.com/en-us/shows/csharp-fundamentals-for-absolute-beginners/more-about-classes-and-methods
*/
using System.Runtime.CompilerServices;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                Static methods of a class do not need a class instance in order for them to be used
            */
            Car.Drive();

            Car myCar = new Car();

            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            // Car myOtherCar = myCar;
            Car myOtherCar = new Car();

            myOtherCar.Make = "Oldsmobile";
            myOtherCar.Model = "Cutlas Supreme";
            myOtherCar.Year = 1986;
            myOtherCar.Color = "Silver";

            Console.WriteLine("myCar: {0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color
            );

            /* Modify the referenced object */
            myOtherCar.Model = "98";

            Console.WriteLine("myOtherCar: {0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color
            );

            /* true */
            Console.WriteLine(myCar == myOtherCar);

            /* remove the "myOtherCar" reference */
            myOtherCar = null;

            /* false */
            Console.WriteLine(myCar == myOtherCar);

            /* New instance with default properties set in the class constructor */
            Car myThirdCar = new Car();
            Console.WriteLine("myThirdCar: {0} {1} {2} {3}",
                myThirdCar.Make,
                myThirdCar.Model,
                myThirdCar.Year,
                myThirdCar.Color
            );

            Car myFourthCar = new Car("Volvo", "V60", 2014, "White");
            Console.WriteLine("myFourthCar: {0} {1} {2} {3}",
                myFourthCar.Make,
                myFourthCar.Model,
                myFourthCar.Year,
                myFourthCar.Color
            );

            Console.ReadLine();
        }
    }
    
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        /* 
            Class constructor method 
            Sets the class instance in a valid state on creation. 
            Values could be passed from a config file, database etc.
        */
        public Car()
        {
            /* "this" is optional */
            this.Make = "Toyota";
            Model = "Corolla";
            Year = 2011;
            Color = "Black";
        }

        /*
            Overloaded constructor
        */
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public static void Drive()
        {
            Console.WriteLine("Vroom!");
        }
    }
}