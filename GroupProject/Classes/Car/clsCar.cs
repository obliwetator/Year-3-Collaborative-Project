using System.Collections.Generic;

namespace GroupProject.Classes.Car
{
	public class ClsCar
	{
		public int Id { get; set; }
		public int ModelId { get; set; }
		public int TypeId { get; set; }
		public int Year { get; set; }
		public string Model { get; set; }
		public string Type { get; set; }
		public float Price { get; set; }
		public Dictionary<string, bool> CarConfigurationsChosen { get; set; }
	}
}