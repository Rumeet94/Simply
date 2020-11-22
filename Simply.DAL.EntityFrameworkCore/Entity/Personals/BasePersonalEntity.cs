using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simply.DAL.EntityFrameworkCore.Entity.Personals {
	public abstract class BasePersonalEntity {
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public string Name { get; set; }

		public string Url { get; set; }

		public IEnumerable<Movie> Movies { get; set; }
	}
}
