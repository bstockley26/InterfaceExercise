using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
	{
		public bool HasSlidingDoors { get; set; }
		public string MidSizeORFullSize { get; set; }
        public int NumberOfDoors { get ; set; }
        public bool HasSunRoof { get ;set ; }
        public int NumberOfSeats { get ; set ; }
        public string Color { get ; set ; }
        public string ManufactoringLocation { get ; set ; }
        public string Logo { get ; set ; }
        public string Make { get; set ; }
        public string Model { get ; set ; }

        public void detailList()
        {
            Console.WriteLine($"This car is a {NumberOfDoors} {Color} {Make} {Model}, it is a {MidSizeORFullSize} made in {ManufactoringLocation}");
        }
    }
}

