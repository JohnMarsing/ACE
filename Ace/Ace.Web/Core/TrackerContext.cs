using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ace.Web.Core
{
	public class TrackerContext : DbContext
	{
		public DbSet<Step> Steps { get; set; }
		public DbSet<Contact> Contacts { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder
					.UseSqlServer(@"Data Source=WIN81DESKTOP\SQLEXPRESS01;Initial Catalog=TrackerDB;Trusted_Connection=True;MultipleActiveResultSets=true;");
		}

	}
}
//.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=TrackerDB;");

/*
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
				: base(options)
		{
		}
	}
 */
