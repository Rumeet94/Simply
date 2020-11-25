using System.Collections.Generic;
using System.Diagnostics.Contracts;

using Simply.DAL.EntityFrameworkCore.Entity.Personals;
using Simply.DAL.EntityFrameworkCore.Entity.Types.Bases;

namespace Simply.DAL.EntityFrameworkCore.Entity.Types {
	public class Country : EntityTypeWithMovie {
		public Country() {
		}

		public Country(IEnumerable<Movie> movies, IEnumerable<Owner> owners)
			: base(movies) {
			Contract.Requires(owners != null);

			Owners = owners;
		}

		public IEnumerable<Owner> Owners { get; set; }
	}
}
