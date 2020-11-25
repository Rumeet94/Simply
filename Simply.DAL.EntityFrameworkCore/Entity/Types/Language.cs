using System.Collections.Generic;

using Simply.DAL.EntityFrameworkCore.Entity.Types.Bases;

namespace Simply.DAL.EntityFrameworkCore.Entity.Types {
	public class Language : EntityTypeWithMovie {
		public Language() {
		}

		public Language(IEnumerable<Movie> movies)
			: base(movies) {
		}
	}
}
