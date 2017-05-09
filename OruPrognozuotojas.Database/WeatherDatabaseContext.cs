using OruPrognozuotojas.Database.Models;
using System.Data.Entity;

namespace OruPrognozuotojas.Database
{
	public class WeatherDatabaseContext : DbContext
    {
		public WeatherDatabaseContext(): base("name=DefaultConnection")
		{
		}

		public virtual DbSet<Weather> Weathers { get; set; }
	}
}
