using Microsoft.EntityFrameworkCore;

using Simply.DAL.EntityFrameworkCore.Models.Types;

namespace Simply.DAL.EntityFrameworkCore.Configurations.CreaterStrategies {
	internal class LanguageDbModelCreaterStrategy : IDbModelCreaterStrategy {
		public void CreateModel(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Language>()
				.Property(l => l.Id)
				.ValueGeneratedOnAdd();
		}
	}
}
