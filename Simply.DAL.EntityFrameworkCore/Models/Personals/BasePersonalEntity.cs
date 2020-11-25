using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace Simply.DAL.EntityFrameworkCore.Models.Personals {
	public abstract class BasePersonalEntity {
		public BasePersonalEntity() {
		}

		public BasePersonalEntity(List<Movie> movies) {
			Contract.Requires(movies != null);

			Movies = movies;
		}

		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public string Name { get; set; }

		public string Url { get; set; }

		public List<Movie> Movies { get; set; }
	}
}
