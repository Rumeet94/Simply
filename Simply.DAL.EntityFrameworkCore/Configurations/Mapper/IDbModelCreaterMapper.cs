using System.Collections.Generic;

using Simply.DAL.EntityFrameworkCore.Configurations.CreaterStrategies;

namespace Simply.DAL.EntityFrameworkCore.Configurations.Mapper {
	internal interface IDbModelCreaterMapper {
		IEnumerable<IDbModelCreaterStrategy> Map();
	}
}
