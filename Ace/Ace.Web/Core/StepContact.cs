using System.ComponentModel.DataAnnotations.Schema;

namespace Ace.Web.Core
{
    [Table("StepContact", Schema = "BallotTrack")]
    public class StepContact
    {
        public int StepContactId { get; set; }

        public int StepId { get; set; }
        public Step Step { get; set; }

        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}
