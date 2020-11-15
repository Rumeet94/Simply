using System;
using System.Collections.Generic;

using Simply.BLL.Dto;
using Simply.BLL.Servicies;

namespace Simply.PL.ConsoleApp {
	class Program {
		static void Main(string[] args) {
			var service = new BookService();

			AddBooks(service);
			GetBooks(service);
		}

		private static void GetBooks(BookService service) {
			var books = service.GetBooks();

			foreach (var book in books) {
				Console.WriteLine($"{book.Id} {book.Name} {book.Pages}");
			}

			Console.ReadKey();
		}

		private static void AddBooks(BookService service) {
			var isAddedBooks = service.AddBooks(
				new List<BookDto> {
					new BookDto {
						Id = 1,
						Name = "Book1",
						Pages = 200
					},
					new BookDto {
						Id = 2,
						Name = "Book2",
						Pages = 100
					}
				}
			);

			Console.WriteLine($"Added books: {isAddedBooks}");
		}
	}
}
