using System.ComponentModel.DataAnnotations.Schema;

namespace Ace.Web.Core
{
	public class Contact
	{
		public int ContactId { get; set; }
		public string FullName { get; set; }
		public string PhoneNbr { get; set; }
		public bool IsPrimary { get; set; }

		[ForeignKey("ContactId")]
		public virtual Step Step { get; set; }
	}
}
