using System.Collections.Generic;

namespace Ace.Web.Core
{
	public class Step
	{
		public int StepId { get; set; }
		public string StepName { get; set; }
		public int ContactId { get; set; }
		public virtual List<Contact> Contacts { get; set; }
	}
}
