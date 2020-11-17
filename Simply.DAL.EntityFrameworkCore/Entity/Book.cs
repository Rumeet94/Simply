using System.ComponentModel.DataAnnotations.Schema;

namespace Simply.DAL.EntityFrameworkCore.Entity {
	public class Book {
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public string Name { get; set; }

		public int Pages { get; set; }
	}
}
