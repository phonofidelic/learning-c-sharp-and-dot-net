/*
        Collections:
            * Lists
            * Dictionaries
*/
using System.Collections;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "B1";

            Book book1 = new Book();
            book1.Author = "Robert Tabor";
            book1.Title = "Microsoft .NET XML Web Services";
            book1.ISBN = "0-000-00000-0";

            // /*
            //     ArrayLists are dynamically sized
            //     includes sorting and removal of items
            // */
            // ArrayList myArrayList = new ArrayList();
            // myArrayList.Add(car1);
            // myArrayList.Add(car2);
            // /* Causes type error when accessing 'Make' in a loop */
            // myArrayList.Add(book1);
            // myArrayList.Remove(book1);

            // foreach (Car car in myArrayList)
            // {
            //     Console.WriteLine(car.Make);
            // }

            // /*
            //     Generics:
            //     List<Type>
            // */
            // List<Car> myList = new List<Car>();
            // myList.Add(car1);
            // myList.Add(car2);
            // /* Is caught with exception */
            // // myList.Add(book1);

            // foreach (Car car in myList)
            // {
            //     Console.WriteLine(car.Make);
            // }

            // /*
            //     Dictionary<TKey, TValue>
            // */
            // // Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            // // myDictionary.Add(car1.VIN, car1);
            // // myDictionary.Add(car2.VIN, car2);

            /* Object initializer syntax: */
            Car car3 = new Car() { Make = "Toyota", Model = "Camry", VIN = "B1" };
            /* Simplified: */
            Car car4 = new() { Make = "Volvo", Model = "V60", VIN = "C1" };

            /* Collection initializer syntax: */
            Dictionary<string, Car> myDictionary = new()
            {
                { car1.VIN, car1 },
                { car2.VIN, car2 }
            };
            List<Car> myList = new List<Car>()
            {
                car3,
                car4,
                new Car { Make = "Volvo", Model = "V60", VIN = "D1" }
            };

            Console.WriteLine(myDictionary["A1"].Make);
            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }

            Console.ReadLine();
        }

        class Car
        {
            public string VIN { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
        }
    }
}