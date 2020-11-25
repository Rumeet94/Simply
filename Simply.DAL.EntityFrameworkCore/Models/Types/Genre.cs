using System.Collections.Generic;

using Simply.DAL.EntityFrameworkCore.Models.Types.Bases;

namespace Simply.DAL.EntityFrameworkCore.Models.Types {
	public class Genre : EntityTypeWithMovie {
		public Genre() {
		}

		public Genre(List<Movie> movies)
			: base(movies) {
		}
	}
}
