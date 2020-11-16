using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * done- Create an abstract class called Vehicle
             * done- The vehicle class shall have three string properties Year, Make, and Model
             * done- Set the defaults to something generic in the Vehicle class
             * done- Vehicle shall have an abstract method called DriveAbstract with no implementation
             * done- Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * done- Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * done- Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * done- Provide the implementations for the abstract methods
             * done- Only in the Motorcycle class will you override the virtual drive method
            */

            // done- Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * done- Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * done- Set the properties with object initializer syntax
             */
            var wrx = new Car() { HasTrunk = true, Make = "Subaru", Model = "WRX", Year = 2017 };
            var dirtBike = new Motorcycle() { HasSideCart = false, Make = "Honda", Model = "CRF", Year = 2010 };
            Vehicle van = new Car() { Make = "Dodge", Model = "Caravan", Year = 1988 };
            Vehicle truck = new Car() { HasTrunk = false, Make = "Ford", Model = "Ranger", Year = 2001 };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(wrx);
            vehicles.Add(dirtBike);
            vehicles.Add(van);
            vehicles.Add(truck);

            foreach(var v in vehicles)
            {
                Console.WriteLine($"Make: {v.Make}, Model: {v.Model}, Year: {v.Year}");
                v.DriveAbstract();
                Console.WriteLine("");
            }
            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
