using Microsoft.EntityFrameworkCore;

using Simply.DAL.EntityFrameworkCore.DbModelCreaters;
using Simply.DAL.EntityFrameworkCore.Entity;
using Simply.DAL.EntityFrameworkCore.Entity.Personals;
using Simply.DAL.EntityFrameworkCore.Entity.Types;
using Simply.DAL.EntityFrameworkCore.Initializers;

namespace Simply.DAL.EntityFrameworkCore.Context {
	public class SimplyDbContext : DbContext {
		private const string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=SimplyDb;Trusted_Connection=True;";

		public DbSet<Movie> Movies { get; set; }

		public DbSet<Member> Members { get; set; }

		public DbSet<MemberType> MemberTypes { get; set; }

		public DbSet<Owner> Owners { get; set; }

		public DbSet<Country> Country { get; set; }

		public DbSet<Genre> Genres { get; set; }

		public DbSet<Language> Languages { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			optionsBuilder.UseSqlServer(_connectionString);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			new GenreDbModelCreater().CreateModel(modelBuilder);
			new OwnerDbModelCreater().CreateModel(modelBuilder);
			new MovieDbModelCreater().CreateModel(modelBuilder);

			new SimplyDbInitializer().InitializeTables(modelBuilder);
		}
	}
}
