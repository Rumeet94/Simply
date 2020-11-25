using Microsoft.EntityFrameworkCore;

namespace Simply.DAL.EntityFrameworkCore.Initializers {
	internal interface ISimplyDbInitializer {
		void Initialize(ModelBuilder modelBuilder);
	}
}
