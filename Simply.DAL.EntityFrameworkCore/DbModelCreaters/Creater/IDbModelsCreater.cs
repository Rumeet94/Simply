using Microsoft.EntityFrameworkCore;

namespace Simply.DAL.EntityFrameworkCore.DbModelCreaters.Creater {
	internal interface IDbModelsCreater {
		void CreateModels(ModelBuilder modelBuilder);
	}
}
