namespace GroupProject.Classes.Salesman
{
	public class ClsSalesmanUserCarConfiguration
	{
		public int ConfigId { get; set; }
		public string ConfigDescription { get; set; }
		public int UserId { get; set; }
		public int CarId { get; set; }
		public bool Review { get; set; }
		public bool WasReviewed { get; set; }
		public int ModificationId { get; set; }
		public int ModelId { get; set; }
		public int TypeId { get; set; }
		public int Year { get; set; }
		public float Price { get; set; }
		public string Type { get; set; }
		public string Model { get; set; }
	}
}