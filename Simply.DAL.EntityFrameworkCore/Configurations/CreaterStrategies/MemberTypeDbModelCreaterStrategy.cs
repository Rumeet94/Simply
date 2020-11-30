using Microsoft.EntityFrameworkCore;

using Simply.DAL.EntityFrameworkCore.Models.Types;

namespace Simply.DAL.EntityFrameworkCore.Configurations.CreaterStrategies {
	internal class MemberTypeDbModelCreaterStrategy : IDbModelCreaterStrategy {
		public void CreateModel(ModelBuilder modelBuilder) {
			modelBuilder.Entity<MemberType>()
				.Property(m => m.Id)
				.ValueGeneratedOnAdd();
		}
	}
}
