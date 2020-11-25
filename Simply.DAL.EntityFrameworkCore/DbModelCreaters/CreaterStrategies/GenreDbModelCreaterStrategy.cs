using Microsoft.EntityFrameworkCore;

using Simply.DAL.EntityFrameworkCore.Entity.Types;

namespace Simply.DAL.EntityFrameworkCore.DbModelCreaters.CreaterStrategies {
	internal class GenreDbModelCreaterStrategy : IDbModelCreaterStrategy {
		public void CreateModel(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Genre>()
				.Property(g => g.Id)
				.ValueGeneratedOnAdd();
		}
	}
}
