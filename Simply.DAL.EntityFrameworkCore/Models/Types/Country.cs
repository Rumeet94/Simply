using System.Collections.Generic;
using System.Diagnostics.Contracts;

using Simply.DAL.EntityFrameworkCore.Models.Personals;
using Simply.DAL.EntityFrameworkCore.Models.Types.Bases;

namespace Simply.DAL.EntityFrameworkCore.Models.Types {
	public class Country : TypeModelWithMovie {
		public Country() {
		}

		public Country(List<Movie> movies, List<Owner> owners)
			: base(movies) {
			Contract.Requires(owners != null);

			Owners = owners;
		}

		public List<Owner> Owners { get; set; }
	}
}
