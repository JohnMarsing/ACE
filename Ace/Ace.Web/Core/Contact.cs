using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ace.Web.Core
{
    [Table("Contact", Schema = "BallotTrack")]
    public class Contact
	{
		public int ContactId { get; set; }
		public string FullName { get; set; }
		public string PhoneNbr { get; set; }
		public bool IsPrimary { get; set; }
        
        public virtual List<StepContact> StepsContact { get; set; }
    }
}
