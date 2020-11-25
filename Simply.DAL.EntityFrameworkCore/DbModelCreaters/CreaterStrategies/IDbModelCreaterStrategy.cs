using Microsoft.EntityFrameworkCore;

namespace Simply.DAL.EntityFrameworkCore.DbModelCreaters.CreaterStrategies {
	internal interface IDbModelCreaterStrategy {
		void CreateModel(ModelBuilder modelBuilder);
	}
}
