using Microsoft.EntityFrameworkCore;

using Simply.DAL.EntityFrameworkCore.Entity.Personals;

namespace Simply.DAL.EntityFrameworkCore.DbModelCreaters {
	internal class OwnerDbModelCreater : IDbModelCreater {
		public void CreateModel(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Owner>()
				.Property(o => o.Id)
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<Owner>()
				.HasOne(o => o.Country)
				.WithMany(o => o.Owner)
				.HasForeignKey(m => m.CountryId);
		}
	}
}
