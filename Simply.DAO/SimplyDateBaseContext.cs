using System.Data.Entity;

using Simply.DAO.Entities;

namespace Simply.DAO {
    public class SimplyDateBaseContext : DbContext {
		public SimplyDateBaseContext()
			: base("name=SimplyDateBaseContext") {
		}

		public DbSet<Person> Persons { get; set; }

		public DbSet<Book> Books { get; set; }
	}
}