using System.Collections.Generic;

namespace Simply.DAL.EntityFrameworkCore.Entity.Types.Bases {
	public abstract class EntityTypeWithMovie : BaseEntityType {
		public IEnumerable<Movie> Movies { get; set; }
	}
}
