using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            var carOne = new Car()
            {
                Make = "Porsche",
                Model = "911 turbo",
                Color = "Grey",
                NumberOfDoors = 2,
                HasSunRoof = false,
                IsStickShift = "Stick Shift",
                Logo = "red and black with horse in middle",
                IsConvertable = false,
                ManufactoringLocation = "Germany",
                NumberOfSeats = 4,

            };
            var carTwo = new Truck()
            {
                Make = "Ford",
                Model = "Raptor",
                Color = "black",
                NumberOfDoors = 4,
                HasSunRoof = true,
                Logo = "blue circle with ford inside",
                ManufactoringLocation = "USA",
                NumberOfSeats = 5,
                OffRoadTires = "Yes",
                OpenOrClosedBed = "Open",

            };

            var carThree = new SUV()
            {
                Make = "Toyota",
                Model = "4runner",
                Color = "White",
                NumberOfDoors = 4,
                NumberOfSeats = 5,
                MidSizeORFullSize = "Fullsized",
                HasSlidingDoors = false,
                HasSunRoof = true,
                Logo = "two ovals creating a T",
                ManufactoringLocation = "Japan",
            };
            carOne.detailList();
            carTwo.detailList();
            carThree.detailList();
        }
    }
}
