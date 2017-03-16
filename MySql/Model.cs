using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql
{
	public class Model
	{
		public class LibraryContext : DbContext
		{
			public LibraryContext() : base("LibraryContext") { }
			public DbSet<Book> Books { get; set; }

		}

		public class Book
		{
			[Key]
			public int Id { get; set; }
			public string Title { get; set; }
		}
	}
}
