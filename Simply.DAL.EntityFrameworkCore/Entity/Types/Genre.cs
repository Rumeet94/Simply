using System.Collections.Generic;

using Simply.DAL.EntityFrameworkCore.Entity.Types.Bases;

namespace Simply.DAL.EntityFrameworkCore.Entity.Types {
	public class Genre : EntityTypeWithMovie {
		public Genre() {
		}

		public Genre(IEnumerable<Movie> movies)
			: base(movies) {
		}
	}
}
