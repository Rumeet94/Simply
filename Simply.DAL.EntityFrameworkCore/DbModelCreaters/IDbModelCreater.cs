using Microsoft.EntityFrameworkCore;

namespace Simply.DAL.EntityFrameworkCore.DbModelCreaters {
	internal interface IDbModelCreater {
		void CreateModel(ModelBuilder modelBuilder);
	}
}
