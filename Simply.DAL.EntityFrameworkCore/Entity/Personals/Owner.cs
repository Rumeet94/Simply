using Simply.DAL.EntityFrameworkCore.Entity.Types;

namespace Simply.DAL.EntityFrameworkCore.Entity.Personals {
	public class Owner : BasePersonalEntity {
		public int? CountryId { get; set; }

		public Country Country { get; set; }
	}
}
