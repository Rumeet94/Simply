using Microsoft.EntityFrameworkCore;

using Simply.DAL.EntityFrameworkCore.Entity;

namespace Simply.DAL.EntityFrameworkCore.DbModelCreaters.CreaterStrategies {
	internal class MovieDbModelCreaterStrategy : IDbModelCreaterStrategy {
		public void CreateModel(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Movie>()
				.Property(m => m.Id)
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<Movie>()
				.HasOne(m => m.Language)
				.WithMany(l => l.Movies)
				.HasForeignKey(m => m.LanguageId);

			modelBuilder.Entity<Movie>()
				.HasOne(m => m.Genre)
				.WithMany(g => g.Movies)
				.HasForeignKey(m => m.GenreId);

			modelBuilder.Entity<Movie>()
				.HasOne(m => m.Country)
				.WithMany(c => c.Movies)
				.HasForeignKey(m => m.CountryId);

			modelBuilder.Entity<Movie>()
				.HasOne(m => m.Owner)
				.WithMany(c => c.Movies)
				.HasForeignKey(m => m.OwnerId);

			modelBuilder.Entity<Movie>()
				.HasMany(m => m.Members)
				.WithMany(m => m.Movies);
		}
	}
}
