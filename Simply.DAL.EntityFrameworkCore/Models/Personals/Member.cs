using System.Collections.Generic;

using Simply.DAL.EntityFrameworkCore.Models.Types;

namespace Simply.DAL.EntityFrameworkCore.Models.Personals {
	public class Member : BasePersonalEntity {
		public Member() {
		}

		public Member(List<Movie> movies)
			: base(movies) {
		}

		public int? TypeId { get; set; }

		public MemberType Type { get; set; }
	}
}
