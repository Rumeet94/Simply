using Microsoft.EntityFrameworkCore;

using Simply.DAL.EntityFrameworkCore.DbModelCreaters.Creater;
using Simply.DAL.EntityFrameworkCore.Entity;
using Simply.DAL.EntityFrameworkCore.Entity.Personals;
using Simply.DAL.EntityFrameworkCore.Entity.Types;
using Simply.DAL.EntityFrameworkCore.Initializers;

namespace Simply.DAL.EntityFrameworkCore.Context {
	internal class SimplyDbContext : DbContext {
		private const string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=SimplyDb;Trusted_Connection=True;";

		private readonly IDbModelsCreater _dbModelsCreater = new DbModelCreater();
		private readonly ISimplyDbInitializer _dbInitializer = new SimplyDbInitializer();

		public DbSet<Movie> Movies { get; set; }

		public DbSet<Member> Members { get; set; }

		public DbSet<MemberType> MemberTypes { get; set; }

		public DbSet<Owner> Owners { get; set; }

		public DbSet<Country> Countries { get; set; }

		public DbSet<Genre> Genres { get; set; }

		public DbSet<Language> Languages { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			optionsBuilder.UseSqlServer(_connectionString);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			_dbModelsCreater.CreateModels(modelBuilder);
			_dbInitializer.Initialize(modelBuilder);
		}
	}
}
