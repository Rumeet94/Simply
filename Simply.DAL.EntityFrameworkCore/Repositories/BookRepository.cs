using System;
using System.Collections.Generic;
using System.Linq;

using Simply.DAL.EntityFrameworkCore.Context;
using Simply.DAL.EntityFrameworkCore.Entity;

namespace Simply.DAL.EntityFrameworkCore.Repositories {
	public class BookRepository {
		public bool AddBooks(IEnumerable<Book> books) {
			try {
				using var context = new SimplyDbContext();

				context.AddRange(books);
				context.SaveChanges();

				return true;
			}
			catch(Exception e) {
				return false;
			}
		}

		public IEnumerable<Book> GetBooks() {
			try {
				using var context = new SimplyDbContext();

				return context.Books.ToList();
			}
			catch(Exception e) {
				return null;
			}
		}
	}
}
