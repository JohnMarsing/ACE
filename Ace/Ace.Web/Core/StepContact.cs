namespace Ace.Web.Core
{
    public class StepContact
    {
        public int StepContactId { get; set; }

        public int StepId { get; set; }
        public Step Step { get; set; }

        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}
