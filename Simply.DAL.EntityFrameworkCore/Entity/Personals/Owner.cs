using System.Collections.Generic;

using Simply.DAL.EntityFrameworkCore.Entity.Types;

namespace Simply.DAL.EntityFrameworkCore.Entity.Personals {
	public class Owner : BasePersonalEntity {
		public Owner() {
		}

		public Owner(IEnumerable<Movie> movies)
			: base (movies) {
		}

		public int? CountryId { get; set; }

		public Country Country { get; set; }
	}
}
