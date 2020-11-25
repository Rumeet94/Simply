using System.Linq;

using Microsoft.EntityFrameworkCore;

using Simply.DAL.EntityFrameworkCore.Configurations.Mapper;

namespace Simply.DAL.EntityFrameworkCore.Configurations.Creater {
	internal class DbModelCreater : IDbModelsCreater {
		private readonly IDbModelCreaterMapper _mapper = new DbModelCreaterMapper();

		public void CreateModels(ModelBuilder modelBuilder) {
			var models = _mapper.Map().ToList();

			models.ForEach(m => m.CreateModel(modelBuilder));
		}
	}
}
