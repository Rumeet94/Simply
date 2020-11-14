using System;
using Simply.DAO;
using Simply.DAO.Entities;

namespace DbTest {
	class Program {
		static void Main(string[] args) {
			using SimplyDateBaseContext dateBaseContext = new SimplyDateBaseContext();

			dateBaseContext.Persons.AddRange(
				new[] {
					new Person {
						Id = 4,
						Name = "Ivan",
						LastName = "Petrov"
					},
					new Person {
						Id = 2,
						Name = "Semem",
						LastName = "Vasiliev"
					},
					new Person {
						Id = 3,
						Name = "Semem",
						LastName = "Vasiliev"
					},
				}
			);

			dateBaseContext.Books.AddRange(
				new[] {
					new Book { Id = 1, Name = "One"},
					new Book { Id = 2, Name = "Two"}
				}
			);

			dateBaseContext.SaveChanges();

			foreach(var book in dateBaseContext.Books) {
				Console.WriteLine($"{book.Id} {book.Name}");
			}

			Console.ReadKey();
		}
	}
}
