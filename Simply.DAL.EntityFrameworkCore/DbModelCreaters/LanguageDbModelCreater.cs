using Microsoft.EntityFrameworkCore;

using Simply.DAL.EntityFrameworkCore.Entity.Types;

namespace Simply.DAL.EntityFrameworkCore.DbModelCreaters {
	internal class LanguageDbModelCreater : IDbModelCreater {
		public void CreateModel(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Language>()
				.Property(l => l.Id)
				.ValueGeneratedOnAdd();
		}
	}
}
