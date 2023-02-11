using Microsoft.EntityFrameworkCore;
using verstaTest.Models;

namespace verstaTest.Data
{
	public class OrderContext : DbContext
	{
		public DbSet<Order> Orders { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql(@"Host=localhost;Username=postgres;Password=root;Port=5432;Database=verstaDb");
		}
	}
}
