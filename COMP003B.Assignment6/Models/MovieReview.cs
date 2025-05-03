using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment6.Models
{
	public class MovieReview
	{
		public int UserId { get; set; }
		public int ReviewId { get; set; }
		[Range(1, 10, ErrorMessage = "Rating must be between 1-10.")]
		public int Rating { get; set; }

		public virtual Movie? Movie { get; set; }
		public virtual MovieDirector? MovieDirector { get; set; }

	}
}
