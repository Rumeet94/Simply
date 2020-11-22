using Microsoft.EntityFrameworkCore;

using Simply.DAL.EntityFrameworkCore.Entity.Types;

namespace Simply.DAL.EntityFrameworkCore.DbModelCreaters {
	internal class GenreDbModelCreater : IDbModelCreater {
		public void CreateModel(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Genre>()
				.Property(g => g.Id)
				.ValueGeneratedOnAdd();
		}
	}
}
