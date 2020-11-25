using System.Collections.Generic;

using Simply.DAL.EntityFrameworkCore.Entity.Types;

namespace Simply.DAL.EntityFrameworkCore.Initializers.Data {
	internal class MemberTypeInitializerData : IInitializerData<MemberType> {
		public IEnumerable<MemberType> GetData() {
			yield return new MemberType { Id = 1, Name = "Actor" };
			yield return new MemberType { Id = 2, Name = "Producer" };
			yield return new MemberType { Id = 3, Name = "Director" };
			yield return new MemberType { Id = 4, Name = "Screenwriter" };
		}
	}
}
