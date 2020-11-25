using System.Collections.Generic;
using System.Diagnostics.Contracts;

using Simply.DAL.EntityFrameworkCore.Entity.Personals;
using Simply.DAL.EntityFrameworkCore.Entity.Types.Bases;

namespace Simply.DAL.EntityFrameworkCore.Entity.Types {
	public class MemberType : BaseEntityType {
		public MemberType() {
		}

		public MemberType(IEnumerable<Member> members) {
			Contract.Requires(members != null);

			Members = members;
		}

		public IEnumerable<Member> Members { get; set; }
	}
}
