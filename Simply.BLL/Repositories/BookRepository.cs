using System;
using System.Collections.Generic;
using System.Linq;

using Simply.DAL.EntityFramework;
using Simply.DAL.EntityFramework.Entity;

namespace Simply.BLL.Repositories {
	public class BookRepository {
		public bool AddBooks(IEnumerable<Book> books) {
			try {
				using (SimplyDbContext context = new SimplyDbContext()) {
					context.Books.AddRange(books);

					context.SaveChanges();
				}

				return true;
			}
			catch(Exception e) {
				return false;
			}
		}

		public IEnumerable<Book> GetBooks() {
			try {
				using (SimplyDbContext context = new SimplyDbContext()) {
					return context.Books.ToList();
				}
			}
			catch {
				return null;
			}
		}
	}
}
