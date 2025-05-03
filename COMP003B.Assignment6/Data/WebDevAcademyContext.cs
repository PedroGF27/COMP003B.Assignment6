using COMP003B.Assignment6.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.Assignment6.Data
{
	public class WebDevAcademyContext : DbContext
	{
		public WebDevAcademyContext(DbContextOptions<WebDevAcademyContext> options) : base(options)
		{
		}

		public DbSet<Movie> Movies { get; set; }
		public DbSet<MovieDirector> Directors { get; set; }
		public DbSet<MovieReview> Reviews { get; set; }

	}
}
