using System.Collections.Generic;

using Simply.DAL.EntityFrameworkCore.Models.Types.Bases;

namespace Simply.DAL.EntityFrameworkCore.Models.Types {
	public class Language : TypeModelWithMovie {
		public Language() {
		}

		public Language(List<Movie> movies)
			: base(movies) {
		}
	}
}
