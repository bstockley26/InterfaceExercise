using System;
namespace InterfaceExercise
{
	public class Car:IVehicle, ICompany
	{
		public bool IsConvertable { get; set; }
		public string IsStickShift { get; set; }
        public string ManufactoringLocation { get ; set ; }
        public string Logo { get ; set ; }
        public int NumberOfDoors { get ; set ; }
        public bool HasSunRoof { get; set; }
        public int NumberOfSeats { get; set; }
        public string Color { get; set; }
        public string Make { get ; set ; }
        public string Model { get ; set ; }

        public void detailList()
        {
            Console.WriteLine($"This car is a {NumberOfDoors} {Color} {Make} {Model}, some features include {IsStickShift} made in {ManufactoringLocation}");
        }
    }
}

