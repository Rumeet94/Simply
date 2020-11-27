using System.ComponentModel.DataAnnotations.Schema;

namespace Simply.DAL.EntityFrameworkCore.Models.Types.Bases {
	public abstract class BaseTypeModel {
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public string Name { get; set; }
	}
}
