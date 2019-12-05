using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ace.Web.Core
{
	public class Step
	{
		public int StepId { get; set; }
		public string StepName { get; set; }
		
        public int PrimaryContactId { get; set; }
        [ForeignKey("PrimaryContactId")]
        public virtual Contact PrimaryContact { get; set; }

        public int? SecondaryContactId { get; set; }
        [ForeignKey("SecondaryContactId")]
        public virtual Contact SecondaryContact { get; set; }

        //public virtual List<Contact> Contacts { get; set; }


    }
}
