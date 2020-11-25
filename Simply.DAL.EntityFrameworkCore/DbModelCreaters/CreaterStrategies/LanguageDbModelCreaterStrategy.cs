using Microsoft.EntityFrameworkCore;

using Simply.DAL.EntityFrameworkCore.Entity.Types;

namespace Simply.DAL.EntityFrameworkCore.DbModelCreaters.CreaterStrategies {
	internal class LanguageDbModelCreaterStrategy : IDbModelCreaterStrategy {
		public void CreateModel(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Language>()
				.Property(l => l.Id)
				.ValueGeneratedOnAdd();
		}
	}
}
