using System.Collections.Generic;

using Simply.DAL.EntityFrameworkCore.Entity.Personals;
using Simply.DAL.EntityFrameworkCore.Entity.Types.Bases;

namespace Simply.DAL.EntityFrameworkCore.Entity.Types {
	public class Country : EntityTypeWithMovie {
		public IEnumerable<Owner> Owner { get; set; }
	}
}
