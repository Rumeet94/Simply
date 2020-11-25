using System.Collections.Generic;

using Simply.DAL.EntityFrameworkCore.DbModelCreaters.CreaterStrategies;

namespace Simply.DAL.EntityFrameworkCore.DbModelCreaters.Mapper {
	internal interface IDbModelCreaterMapper {
		IEnumerable<IDbModelCreaterStrategy> Map();
	}
}
