namespace COMP003B.Assignment6.Models
{
	public class Movie
	{
		public int MovieId { get; set; }

		public string MovieName { get; set; }

		public string MovieDescription { get; set; }

		public virtual ICollection<Movie>? MovieDirector { get; set; }
	}
}
