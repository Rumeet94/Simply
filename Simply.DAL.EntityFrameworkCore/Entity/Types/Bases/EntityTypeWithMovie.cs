using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Simply.DAL.EntityFrameworkCore.Entity.Types.Bases {
	public abstract class EntityTypeWithMovie : BaseEntityType {
		public EntityTypeWithMovie() {
		}

		public EntityTypeWithMovie(IEnumerable<Movie> movies) {
			Contract.Requires(movies != null);

			Movies = movies;
		}

		public IEnumerable<Movie> Movies { get; set; }
	}
}
