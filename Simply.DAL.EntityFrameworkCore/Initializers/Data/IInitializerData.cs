using System.Collections.Generic;

namespace Simply.DAL.EntityFrameworkCore.Initializers.Data {
	interface IInitializerData<T> {
		IEnumerable<T> GetData();
	}
}
