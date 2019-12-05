using Ace.Web.Core;
using Microsoft.EntityFrameworkCore;
using System;

namespace Ace.Web.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region Step
            modelBuilder.Entity<Step>().HasData(new Step
            {
                StepId = 1,
                StepName = "Mail Room",
                VaultHoldIsAvailable = false,
                BoxCheckInRequired = false,
                IsBoxEntryStep = true,
                PrefillBallotCount = true,
                AllowToGoBackStep = false,
                DefaultNextStep = 2,
                CreatedBy = "073098",
                DateCreated = DateTime.Now,
                ModifiedBy = "077471",
                DateModified = DateTime.Now,
            });

            modelBuilder.Entity<Step>().HasData(new Step
            {
                StepId = 2,
                StepName = "Early Voting",
                VaultHoldIsAvailable = true,
                BoxCheckInRequired = true,
                IsBoxEntryStep = true,
                PrefillBallotCount = true,
                AllowToGoBackStep = false,
                DefaultNextStep = 3,
                CreatedBy = "077471",
                DateCreated = DateTime.Now,
                ModifiedBy = "077471",
                DateModified = DateTime.Now,
            });

            modelBuilder.Entity<Step>().HasData(new Step
            {
                StepId = 3,
                StepName = "Early Ballot Board Verification",
                VaultHoldIsAvailable = true,
                BoxCheckInRequired = true,
                IsBoxEntryStep = false,
                PrefillBallotCount = false,
                AllowToGoBackStep = false,
                DefaultNextStep = 4,
                CreatedBy = "077471",
                DateCreated = DateTime.Now,
                ModifiedBy = "077471",
                DateModified = DateTime.Now,
            });

            modelBuilder.Entity<Step>().HasData(new Step
            {
                StepId = 4,
                StepName = "Early Ballot Board Ins Ctrl Brd",
                VaultHoldIsAvailable = true,
                BoxCheckInRequired = true,
                IsBoxEntryStep = false,
                PrefillBallotCount = false,
                AllowToGoBackStep = false,
                DefaultNextStep = 5,
                CreatedBy = "077471",
                DateCreated = DateTime.Now,
                ModifiedBy = "077471",
                DateModified = DateTime.Now,
            });

            modelBuilder.Entity<Step>().HasData(new Step
            {
                StepId = 5,
                StepName = "Tabulation", 
                VaultHoldIsAvailable = true,
                BoxCheckInRequired = true,
                IsBoxEntryStep = false,
                PrefillBallotCount = false,
                AllowToGoBackStep = false,
                DefaultNextStep = 6,
                CreatedBy = "077471",
                DateCreated = DateTime.Now,
                ModifiedBy = "077471",
                DateModified = DateTime.Now,
            });

            modelBuilder.Entity<Step>().HasData(new Step
            {
                StepId = 6,
                StepName = "Completed to Vault",
                VaultHoldIsAvailable = false,
                BoxCheckInRequired = true,
                IsBoxEntryStep = false,
                PrefillBallotCount = false,
                AllowToGoBackStep = true,
                DefaultNextStep = 6,
                CreatedBy = "077471",
                DateCreated = DateTime.Now,
                ModifiedBy = "077471",
                DateModified = DateTime.Now,
            });

            modelBuilder.Entity<Step>().HasData(new Step
            {
                StepId = 7,
                StepName = "Vault Hold",
                VaultHoldIsAvailable = false,
                BoxCheckInRequired = true,
                IsBoxEntryStep = false,
                PrefillBallotCount = false,
                AllowToGoBackStep = false,
                DefaultNextStep = null,
                CreatedBy = "073098",
                DateCreated = DateTime.Now,
                ModifiedBy = "073098",
                DateModified = DateTime.Now,
            });
            #endregion

            #region Contact
            modelBuilder.Entity<Contact>().HasData(new Contact
            {
                ContactId = 1,
                FullName = "Alice Cooper",
                IsPrimary = true,
                PhoneNbr = "555-1200" 
            });

            modelBuilder.Entity<Contact>().HasData(new Contact
            {
                ContactId = 2,
                FullName = "Michael Bruce",
                IsPrimary = true,
                PhoneNbr = "555-1201" 
            });

            modelBuilder.Entity<Contact>().HasData(new Contact
            {
                ContactId = 3,
                FullName = "Neal Smith",
                IsPrimary = false,
                PhoneNbr = "555-1202" 
            });

            modelBuilder.Entity<Contact>().HasData(new Contact
            {
                ContactId = 4,
                FullName = "Dennis Dunaway",
                IsPrimary = true,
                PhoneNbr = "555-1203" 
            });

            modelBuilder.Entity<Contact>().HasData(new Contact
            {
                ContactId = 5,
                FullName = "Glen Buxton",
                IsPrimary = false,
                PhoneNbr = "555-1203" 
            });

            modelBuilder.Entity<Contact>().HasData(new Contact
            {
                ContactId = 6,
                FullName = "Mr Nice Guy",
                IsPrimary = true,
                PhoneNbr = "555-1204" 
            });

            modelBuilder.Entity<Contact>().HasData(new Contact
            {
                ContactId = 7,
                FullName = "Vincent Damon Furnier",
                IsPrimary = false,
                PhoneNbr = "555-1205" 
            });
            #endregion

            #region StepContact
            modelBuilder.Entity<StepContact>().HasData(new StepContact { StepContactId = 1, StepId = 1, ContactId = 1 });
            modelBuilder.Entity<StepContact>().HasData(new StepContact { StepContactId = 2, StepId = 2, ContactId = 1 });
            modelBuilder.Entity<StepContact>().HasData(new StepContact { StepContactId = 3, StepId = 2, ContactId = 3 });
            modelBuilder.Entity<StepContact>().HasData(new StepContact { StepContactId = 4, StepId = 3, ContactId = 4 });
            modelBuilder.Entity<StepContact>().HasData(new StepContact { StepContactId = 5, StepId = 3, ContactId = 5 });
            modelBuilder.Entity<StepContact>().HasData(new StepContact { StepContactId = 6, StepId = 4, ContactId = 4 });
            modelBuilder.Entity<StepContact>().HasData(new StepContact { StepContactId = 7, StepId = 4, ContactId = 5 });
            modelBuilder.Entity<StepContact>().HasData(new StepContact { StepContactId = 8, StepId = 5, ContactId = 6 });
            modelBuilder.Entity<StepContact>().HasData(new StepContact { StepContactId = 9, StepId = 5, ContactId = 7 });
            modelBuilder.Entity<StepContact>().HasData(new StepContact { StepContactId = 10, StepId = 6, ContactId = 1 });
            modelBuilder.Entity<StepContact>().HasData(new StepContact { StepContactId = 11, StepId = 6, ContactId = 3 });
            modelBuilder.Entity<StepContact>().HasData(new StepContact { StepContactId = 12, StepId = 7, ContactId = 1 });
            modelBuilder.Entity<StepContact>().HasData(new StepContact { StepContactId = 13, StepId = 7, ContactId = 3 });
            #endregion
        }
    }
}
