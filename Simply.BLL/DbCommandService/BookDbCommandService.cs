using System;
using System.Collections.Generic;
using System.Linq;

using Simply.BLL.Dto;
using Simply.DAL.EntityFrameworkCore.Entity;
using Simply.DAL.EntityFrameworkCore.Repositories;

namespace Simply.BLL.DbCommandService {
	public class BookDbCommandService {
		private readonly BookRepository _repository = new BookRepository();

		public bool AddBooks(IEnumerable<BookDto> books) {
			try {
				var items = books.Select(b => new Book {
					Name = b.Name,
					Pages = b.Pages
				});

				return _repository.AddBooks(items);
			}
			catch(Exception e) {
				return false;
			}
		}
	}
}
