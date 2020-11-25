using System.Collections.Generic;
using System.Diagnostics.Contracts;

using Simply.DAL.EntityFrameworkCore.Models.Personals;
using Simply.DAL.EntityFrameworkCore.Models.Types.Bases;

namespace Simply.DAL.EntityFrameworkCore.Models.Types {
	public class MemberType : BaseEntityType {
		public MemberType() {
		}

		public MemberType(List<Member> members) {
			Contract.Requires(members != null);

			Members = members;
		}

		public List<Member> Members { get; set; }
	}
}
