using Microsoft.EntityFrameworkCore;

using Simply.DAL.EntityFrameworkCore.Models.Types;

namespace Simply.DAL.EntityFrameworkCore.Configurations.CreaterStrategies {
	internal class GenreDbModelCreaterStrategy : IDbModelCreaterStrategy {
		public void CreateModel(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Genre>()
				.Property(g => g.Id)
				.ValueGeneratedOnAdd();
		}
	}
}
