using Microsoft.EntityFrameworkCore;

using Simply.DAL.EntityFrameworkCore.Initializers.Data.Types;
using Simply.DAL.EntityFrameworkCore.Models.Types;

namespace Simply.DAL.EntityFrameworkCore.Initializers {
	internal class SimplyDbInitializer : ISimplyDbInitializer {
		private readonly CountryInitializerData _countryInitializerData = new CountryInitializerData();
		private readonly GenreInitializerData _genreInitializerData = new GenreInitializerData();
		private readonly LanguageInitializerData _languageInitializerData = new LanguageInitializerData();
		private readonly MemberTypeInitializerData _memberTypeInitializerData = new MemberTypeInitializerData();

		public void Initialize(ModelBuilder modelBuilder) {
			modelBuilder.Entity<MemberType>().HasData(_memberTypeInitializerData.GetData());
			modelBuilder.Entity<Language>().HasData(_languageInitializerData.GetData());
			modelBuilder.Entity<Genre>().HasData(_genreInitializerData.GetData());
			modelBuilder.Entity<Country>().HasData(_countryInitializerData.GetData());
		}
	}
}
