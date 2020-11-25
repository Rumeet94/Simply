using Microsoft.EntityFrameworkCore;

namespace Simply.DAL.EntityFrameworkCore.Configurations.CreaterStrategies {
	internal interface IDbModelCreaterStrategy {
		void CreateModel(ModelBuilder modelBuilder);
	}
}
