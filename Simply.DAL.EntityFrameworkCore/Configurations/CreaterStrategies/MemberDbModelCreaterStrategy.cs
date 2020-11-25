using Microsoft.EntityFrameworkCore;

using Simply.DAL.EntityFrameworkCore.Models.Personals;

namespace Simply.DAL.EntityFrameworkCore.Configurations.CreaterStrategies {
	internal class MemberDbModelCreaterStrategy : IDbModelCreaterStrategy {
		public void CreateModel(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Member>()
				.Property(m => m.Id)
				.ValueGeneratedOnAdd();

			modelBuilder.Entity<Member>()
				.HasOne(m => m.Type)
				.WithMany(t => t.Members)
				.HasForeignKey(m => m.TypeId);
		}
	}
}
