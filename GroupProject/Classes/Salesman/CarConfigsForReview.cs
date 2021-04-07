namespace GroupProject.Classes.Salesman
{
	public class CarConfigsForReview
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public int UserId { get; set; }
		public int CarId { get; set; }
		public bool Review { get; set; }
		public bool WasReviewed { get; set; }
	}
}