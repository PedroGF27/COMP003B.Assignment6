namespace COMP003B.Assignment6.Models
{
	public class MovieDirector
	{
		public int MovieDirectorId { get; set; }

		public string MovieDirectorName { get; set; }

		public string MovieDirectorDescription { get; set; }

		public virtual ICollection<MovieDirector>? Movie { get; set; }
	}
}
