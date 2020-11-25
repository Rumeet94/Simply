using Microsoft.EntityFrameworkCore;

using Simply.DAL.EntityFrameworkCore.Models.Types;

namespace Simply.DAL.EntityFrameworkCore.Configurations.CreaterStrategies {
	internal class CountryDbModelCreaterStrategy : IDbModelCreaterStrategy {
		public void CreateModel(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Country>()
				.Property(c => c.Id)
				.ValueGeneratedOnAdd();
		}
	}
}
