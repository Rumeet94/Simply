using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Simply.DAL.EntityFrameworkCore.Models.Types.Bases {
	public abstract class TypeModelWithMovie : BaseTypeModel {
		public TypeModelWithMovie() {
		}

		public TypeModelWithMovie(List<Movie> movies) {
			Contract.Requires(movies != null);

			Movies = movies;
		}

		public List<Movie> Movies { get; set; }
	}
}
