using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using Simply.DAL.EntityFrameworkCore.Entity.Personals;
using Simply.DAL.EntityFrameworkCore.Entity.Types;

namespace Simply.DAL.EntityFrameworkCore.Entity {
	public class Movie {
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public string Name { get; set; }

		public string Discription { get; set; }

		public IEnumerable<Member> Members { get; set; }

		public decimal Rate { get; set; }

		public int? OwnerId { get; set; }

		public Owner Owner { get; set; }

		public int? GenreId { get; set; }

		public Genre Genre { get; set; }

		public int? LanguageId { get; set; }

		public Language Language { get; set; }

		public int? CountryId { get; set; }

		public Country Country { get; set; }
	}
}
