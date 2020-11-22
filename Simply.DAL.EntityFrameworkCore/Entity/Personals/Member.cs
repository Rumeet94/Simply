using Simply.DAL.EntityFrameworkCore.Entity.Types;

namespace Simply.DAL.EntityFrameworkCore.Entity.Personals {
	public class Member : BasePersonalEntity {
		public int? TypeId { get; set; }

		public MemberType Type { get; set; }
	}
}
