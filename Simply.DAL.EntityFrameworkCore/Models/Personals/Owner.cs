using System.Collections.Generic;

using Simply.DAL.EntityFrameworkCore.Models.Types;

namespace Simply.DAL.EntityFrameworkCore.Models.Personals {
	public class Owner : BasePersonalEntity {
		public Owner() {
		}

		public Owner(List<Movie> movies)
			: base(movies) {
		}

		public int? CountryId { get; set; }

		public Country Country { get; set; }
	}
}
