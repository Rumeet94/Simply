using System;
using System.Collections.Generic;
using System.Linq;

using Simply.BLL.DbCommandService;
using Simply.BLL.DbQueryService;
using Simply.BLL.Dto;

namespace Simply.PL.ConsoleApp {
	class Program {
		static void Main(string[] args) {
			AddBooks();
			GetBooks();
		}

		private static void GetBooks() {
			var query = new BookDbQueryService();
			var books = query.GetBooks();

			if (books.Any()) {
				Console.WriteLine("Books not found");
			}

			foreach (var book in books) {
				Console.WriteLine($"{book.Id} {book.Name} {book.Pages}");
			}

			Console.ReadKey();
		}

		private static void AddBooks() {
			var command = new BookDbCommandService();
			var isAddedBooks = command.AddBooks(
				new List<BookDto> {
					new BookDto {
						Name = "Book1",
						Pages = 200
					},
					new BookDto {
						Name = "Book2",
						Pages = 100
					}
				}
			);

			Console.WriteLine($"Added books: {isAddedBooks}");
		}
	}
}
