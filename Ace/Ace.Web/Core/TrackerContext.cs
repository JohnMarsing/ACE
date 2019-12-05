using Microsoft.EntityFrameworkCore;

namespace Ace.Web.Core
{
    public class TrackerContext : DbContext
	{
		public DbSet<Step> Steps { get; set; }
		public DbSet<Contact> Contacts { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder
					.UseSqlServer(@"Data Source=ITS-416957-D\SQLEXPRESS;Initial Catalog=TrackerDB;Trusted_Connection=True;MultipleActiveResultSets=true;");
		}
        //.UseSqlServer(@"Data Source=WIN81DESKTOP\SQLEXPRESS01;Initial Catalog=TrackerDB;Trusted_Connection=True;MultipleActiveResultSets=true;");
    }
}
//.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=TrackerDB;");
//Data Source=ITS-416957-D\SQLEXPRESS;Initial Catalog=TrackerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False

/*
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
				: base(options)
		{
		}
	}
 */
