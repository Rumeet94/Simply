using System.Data.Entity;

using Simply.DAL.EntityFramework.Entity;

namespace Simply.DAL.EntityFramework {
    public class SimplyDbContext : DbContext {
		public SimplyDbContext()
			: base("name=SimplyDbContext") {
		}

		public DbSet<Book> Books { get; set; }
	}
}