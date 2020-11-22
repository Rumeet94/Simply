using System.Collections.Generic;

using Simply.DAL.EntityFrameworkCore.Entity.Personals;
using Simply.DAL.EntityFrameworkCore.Entity.Types.Bases;

namespace Simply.DAL.EntityFrameworkCore.Entity.Types {
	public class MemberType : BaseEntityType {
		public IEnumerable<Member> Members { get; set; }
	}
}
