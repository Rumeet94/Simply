using System;
using System.Collections.Generic;
using System.Linq;

using Simply.BLL.Dto;
using Simply.DAL.EntityFrameworkCore.Repositories;

namespace Simply.BLL.DbQueryService {
	public class BookDbQueryService {
		private readonly BookRepository _repository = new BookRepository();

		public IEnumerable<BookDto> GetBooks() {
			try {
				var books = _repository.GetBooks();

				return books
					.Select(b => new BookDto {
						Id = b.Id,
						Name = b.Name,
						Pages = b.Pages
					})
					.ToList();
			}
			catch(Exception e) {
				return null;
			}
		}
	}
}
