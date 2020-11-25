using System.Linq;

using Microsoft.EntityFrameworkCore;

using Simply.DAL.EntityFrameworkCore.DbModelCreaters.Mapper;

namespace Simply.DAL.EntityFrameworkCore.DbModelCreaters.Creater {
	internal class DbModelCreater : IDbModelsCreater {
		private readonly IDbModelCreaterMapper _mapper = new DbModelCreaterMapper();

		public void CreateModels(ModelBuilder modelBuilder) {
			var models = _mapper.Map().ToList();

			models.ForEach(m => m.CreateModel(modelBuilder));
		}
	}
}
