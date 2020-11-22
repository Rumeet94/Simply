using Microsoft.EntityFrameworkCore;

using Simply.DAL.EntityFrameworkCore.Entity.Types;

namespace Simply.DAL.EntityFrameworkCore.Initializers {
	internal class SimplyDbInitializer : ISimplyDbInitializer {
		public void InitializeTables(ModelBuilder modelBuilder) {
			InitializeCountryTable(modelBuilder);
			InitializeGenreTable(modelBuilder);
			InitializeLanguageTable(modelBuilder);
			InitializeMemberTypeTable(modelBuilder);
		}

		private static void InitializeMemberTypeTable(ModelBuilder modelBuilder) {
			modelBuilder.Entity<MemberType>().HasData(
				new MemberType { Id = 1, Name = "Actor" },
				new MemberType { Id = 2, Name = "Producer" },
				new MemberType { Id = 3, Name = "Director" },
				new MemberType { Id = 4, Name = "Screenwriter" }
			);
		}

		private static void InitializeLanguageTable(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Language>().HasData(
				new Language { Id = 1, Name = "Russian" },
				new Language { Id = 2, Name = "Japanese" },
				new Language { Id = 3, Name = "English" },
				new Language { Id = 4, Name = "Chinese" }
			);
		}

		private static void InitializeGenreTable(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Genre>().HasData(
				new Genre { Id = 1, Name = "Action" },
				new Genre { Id = 2, Name = "Drama" },
				new Genre { Id = 3, Name = "Melodrama" },
				new Genre { Id = 4, Name = "Сombat" }
			);
		}

		private static void InitializeCountryTable(ModelBuilder modelBuilder) {
			modelBuilder.Entity<Country>().HasData(
				new Country { Id = 1, Name = "Russia" },
				new Country { Id = 2, Name = "Japan" },
				new Country { Id = 3, Name = "USA" },
				new Country { Id = 4, Name = "China" }
			);
		}
	}
}
