using Microsoft.EntityFrameworkCore;

using Simply.DAL.EntityFrameworkCore.Entity.Personals;

namespace Simply.DAL.EntityFrameworkCore.DbModelCreaters.CreaterStrategies {
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
