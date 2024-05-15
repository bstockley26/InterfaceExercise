using System;
namespace InterfaceExercise
{
	public class Truck:IVehicle, ICompany
	{
		public string OpenOrClosedBed { get; set; }
		public string OffRoadTires { get; set; }
        public int NumberOfDoors { get ; set ; }
        public bool HasSunRoof { get; set; }
        public int NumberOfSeats { get ; set ; }
        public string Color { get ; set ; }
        public string ManufactoringLocation { get ; set ; }
        public string Logo { get ; set ; }
        public string Make { get; set ; }
        public string Model { get ; set ; }

        public void detailList()
        {
            Console.WriteLine($"Truck List: \n {NumberOfDoors} door {Color} {Make} {Model}  " +
                $" \n offroad tires:{OffRoadTires} \n Made in :{ManufactoringLocation}");
        }
    }
    
}

