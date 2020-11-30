using Microsoft.EntityFrameworkCore;

namespace Simply.DAL.EntityFrameworkCore.Configurations.Creater {
	internal interface IDbModelsCreater {
		void CreateModels(ModelBuilder modelBuilder);
	}
}
