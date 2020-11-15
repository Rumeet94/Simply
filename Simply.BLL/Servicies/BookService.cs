using System.Collections.Generic;
using System.Linq;

using Simply.BLL.Dto;
using Simply.BLL.Repositories;
using Simply.DAL.EntityFramework.Entity;

namespace Simply.BLL.Servicies {
	public class BookService {
		private readonly BookRepository _repository = new BookRepository();

		public bool AddBooks(IEnumerable<BookDto> books) =>
			_repository.AddBooks(
				books.Select(b => new Book {
					Id = b.Id,
					Name = b.Name,
					Pages = b.Pages
				})
			);

		public IEnumerable<BookDto> GetBooks() {
			var books = _repository.GetBooks();

			return books.Select(b => new BookDto {
				Id = b.Id,
				Name = b.Name,
				Pages = b.Pages
			});
		}
	}
}
