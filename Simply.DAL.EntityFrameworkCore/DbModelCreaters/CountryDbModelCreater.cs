using Microsoft.EntityFrameworkCore;

using Simply.DAL.EntityFrameworkCore.Entity.Types;

namespace Simply.DAL.EntityFrameworkCore.DbModelCreaters {
	internal class CountryDbModelCreater : IDbModelCreater {
		public void CreateModel(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Country>()
				.Property(c => c.Id)
				.ValueGeneratedOnAdd();
		}
	}
}
