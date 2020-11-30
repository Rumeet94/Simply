﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

using Simply.DAL.EntityFrameworkCore.Models.Personals;
using Simply.DAL.EntityFrameworkCore.Models.Types;

namespace Simply.DAL.EntityFrameworkCore.Models {
	public class Movie {
		public Movie() {
		}

		public Movie(IEnumerable<Member> members) {
			Contract.Requires(members != null);

			Members = members;
		}

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
