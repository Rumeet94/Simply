using System.Collections.Generic;

using Simply.DAL.EntityFrameworkCore.Models.Types;

namespace Simply.DAL.EntityFrameworkCore.Initializers.Data.Types {
	internal class LanguageInitializerData : IInitializerData<Language> {
		public IEnumerable<Language> GetData() {
			yield return new Language { Id = 1, Name = "Russian" };
			yield return new Language { Id = 2, Name = "Japanese" };
			yield return new Language { Id = 3, Name = "English" };
			yield return new Language { Id = 4, Name = "Chinese" };
		}
	}
}
