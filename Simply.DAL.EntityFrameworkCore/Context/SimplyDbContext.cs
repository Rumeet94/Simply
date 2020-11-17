using Microsoft.EntityFrameworkCore;

using Simply.DAL.EntityFrameworkCore.Entity;

namespace Simply.DAL.EntityFrameworkCore.Context {
	public class SimplyDbContext : DbContext {
		private const string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=SimplyDb;Trusted_Connection=True;";

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			optionsBuilder.UseSqlServer(_connectionString);
		}

		public DbSet<Book> Books { get; set; }
	}
}
