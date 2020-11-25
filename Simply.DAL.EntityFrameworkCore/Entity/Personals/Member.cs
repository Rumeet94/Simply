using System.Collections.Generic;

using Simply.DAL.EntityFrameworkCore.Entity.Types;

namespace Simply.DAL.EntityFrameworkCore.Entity.Personals {
	public class Member : BasePersonalEntity {
		public Member() {
		}

		public Member(IEnumerable<Movie> movies)
			: base (movies) {
		}

		public int? TypeId { get; set; }

		public MemberType Type { get; set; }
	}
}
