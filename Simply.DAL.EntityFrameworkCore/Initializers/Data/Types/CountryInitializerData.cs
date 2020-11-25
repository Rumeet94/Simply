using System.Collections.Generic;

using Simply.DAL.EntityFrameworkCore.Models.Types;

namespace Simply.DAL.EntityFrameworkCore.Initializers.Data.Types {
	public class CountryInitializerData : IInitializerData<Country> {
		public IEnumerable<Country> GetData() {
			yield return new Country { Id = 1, Name = "Russia" };
			yield return new Country { Id = 2, Name = "Japan" };
			yield return new Country { Id = 3, Name = "USA" };
			yield return new Country { Id = 4, Name = "China" };
		}
	}
}
