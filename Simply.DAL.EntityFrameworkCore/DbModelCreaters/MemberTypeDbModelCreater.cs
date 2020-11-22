using Microsoft.EntityFrameworkCore;

using Simply.DAL.EntityFrameworkCore.Entity.Types;

namespace Simply.DAL.EntityFrameworkCore.DbModelCreaters {
	internal class MemberTypeDbModelCreater : IDbModelCreater {
		public void CreateModel(ModelBuilder modelBuilder) {
			modelBuilder.Entity<MemberType>()
				.Property(m => m.Id)
				.ValueGeneratedOnAdd();
		}
	}
}
