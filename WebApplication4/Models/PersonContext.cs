using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class PersonContext : DbContext
    {
		public DbSet<Person> Persons { get; set; }
		public DbSet<ContactInformation> ContactInformations { get; set; }
		public PersonContext() : base("PersonContext")
		{

		}
	}
}