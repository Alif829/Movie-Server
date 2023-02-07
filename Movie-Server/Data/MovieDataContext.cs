using Microsoft.EntityFrameworkCore;
using Movie_Server.Models;

namespace Movie_Server.Data
{
	public class MovieDataContext : DbContext
	{
		public MovieDataContext(DbContextOptions<MovieDataContext> options)
			: base(options)
		{
		}

		public DbSet<Movie> Movie { get; set; }
	}
}
