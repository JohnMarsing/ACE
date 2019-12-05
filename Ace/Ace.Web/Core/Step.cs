using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ace.Web.Core
{
    [Table("Step", Schema = "BallotTrack")]
    public class Step
	{
        public int StepId { get; set; }
		public string StepName { get; set; }
        public bool VaultHoldIsAvailable { get; set; }
        public bool BoxCheckInRequired { get; set; }
        public bool IsBoxEntryStep { get; set; }
        public bool PrefillBallotCount { get; set; }
        public bool AllowToGoBackStep { get; set; }
        public int? DefaultNextStep  { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }

        public virtual List<StepContact> ContactSteps { get; set; }
    }
}
