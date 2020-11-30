using Microsoft.EntityFrameworkCore;

using Simply.DAL.EntityFrameworkCore.Models.Personals;

namespace Simply.DAL.EntityFrameworkCore.Configurations.CreaterStrategies {
	internal class OwnerDbModelCreaterStrategy : IDbModelCreaterStrategy {
		public void CreateModel(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Owner>()
				.Property(o => o.Id)
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<Owner>()
				.HasOne(o => o.Country)
				.WithMany(o => o.Owners)
				.HasForeignKey(m => m.CountryId);
		}
	}
}
