using System;
namespace InterfaceExercise
{
	public interface IVehicle : ICompany
	{
		public int NumberOfDoors { get; set; }
		public bool HasSunRoof { get; set; }
		public int NumberOfSeats { get; set; }
		public string Color { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }

		
	}
}

