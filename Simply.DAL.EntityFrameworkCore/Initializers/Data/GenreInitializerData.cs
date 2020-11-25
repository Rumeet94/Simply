using System.Collections.Generic;

using Simply.DAL.EntityFrameworkCore.Entity.Types;

namespace Simply.DAL.EntityFrameworkCore.Initializers.Data {
	internal class GenreInitializerData : IInitializerData<Genre> {
		public IEnumerable<Genre> GetData() {
			yield return new Genre { Id = 1, Name = "Action" };
			yield return new Genre { Id = 2, Name = "Drama" };
			yield return new Genre { Id = 3, Name = "Melodrama" };
			yield return new Genre { Id = 4, Name = "Сombat" };
		}
	}
}
