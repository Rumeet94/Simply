using System.Collections.Generic;

using Simply.DAL.EntityFrameworkCore.Configurations.CreaterStrategies;

namespace Simply.DAL.EntityFrameworkCore.Configurations.Mapper {
	internal class DbModelCreaterMapper : IDbModelCreaterMapper {
		public IEnumerable<IDbModelCreaterStrategy> Map() {
			yield return new CountryDbModelCreaterStrategy();
			yield return new GenreDbModelCreaterStrategy();
			yield return new LanguageDbModelCreaterStrategy();
			yield return new MemberDbModelCreaterStrategy();
			yield return new MemberTypeDbModelCreaterStrategy();
			yield return new MovieDbModelCreaterStrategy();
			yield return new OwnerDbModelCreaterStrategy();
		}
	}
}
