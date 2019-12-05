﻿// <auto-generated />
using System;
using Ace.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ace.Web.Migrations
{
    [DbContext(typeof(TrackerDBContext))]
    [Migration("20191205224317_StepsCompletedMockData")]
    partial class StepsCompletedMockData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ace.Web.Core.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPrimary")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNbr")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.ToTable("Contact","BallotTrack");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            FullName = "Alice Cooper",
                            IsPrimary = true,
                            PhoneNbr = "555-1200"
                        },
                        new
                        {
                            ContactId = 2,
                            FullName = "Michael Bruce",
                            IsPrimary = true,
                            PhoneNbr = "555-1201"
                        },
                        new
                        {
                            ContactId = 3,
                            FullName = "Neal Smith",
                            IsPrimary = false,
                            PhoneNbr = "555-1202"
                        },
                        new
                        {
                            ContactId = 4,
                            FullName = "Dennis Dunaway",
                            IsPrimary = true,
                            PhoneNbr = "555-1203"
                        },
                        new
                        {
                            ContactId = 5,
                            FullName = "Glen Buxton",
                            IsPrimary = false,
                            PhoneNbr = "555-1203"
                        },
                        new
                        {
                            ContactId = 6,
                            FullName = "Mr Nice Guy",
                            IsPrimary = true,
                            PhoneNbr = "555-1204"
                        },
                        new
                        {
                            ContactId = 7,
                            FullName = "Vincent Damon Furnier",
                            IsPrimary = false,
                            PhoneNbr = "555-1205"
                        });
                });

            modelBuilder.Entity("Ace.Web.Core.Step", b =>
                {
                    b.Property<int>("StepId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AllowToGoBackStep")
                        .HasColumnType("bit");

                    b.Property<bool>("BoxCheckInRequired")
                        .HasColumnType("bit");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DefaultNextStep")
                        .HasColumnType("int");

                    b.Property<bool>("IsBoxEntryStep")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PrefillBallotCount")
                        .HasColumnType("bit");

                    b.Property<string>("StepName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("VaultHoldIsAvailable")
                        .HasColumnType("bit");

                    b.HasKey("StepId");

                    b.ToTable("Step","BallotTrack");

                    b.HasData(
                        new
                        {
                            StepId = 1,
                            AllowToGoBackStep = false,
                            BoxCheckInRequired = false,
                            CreatedBy = "073098",
                            DateCreated = new DateTime(2019, 12, 5, 15, 43, 17, 316, DateTimeKind.Local).AddTicks(2710),
                            DateModified = new DateTime(2019, 12, 5, 15, 43, 17, 318, DateTimeKind.Local).AddTicks(8762),
                            DefaultNextStep = 2,
                            IsBoxEntryStep = true,
                            ModifiedBy = "077471",
                            PrefillBallotCount = true,
                            StepName = "Mail Room",
                            VaultHoldIsAvailable = false
                        },
                        new
                        {
                            StepId = 2,
                            AllowToGoBackStep = false,
                            BoxCheckInRequired = true,
                            CreatedBy = "077471",
                            DateCreated = new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2364),
                            DateModified = new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2390),
                            DefaultNextStep = 3,
                            IsBoxEntryStep = true,
                            ModifiedBy = "077471",
                            PrefillBallotCount = true,
                            StepName = "Early Voting",
                            VaultHoldIsAvailable = true
                        },
                        new
                        {
                            StepId = 3,
                            AllowToGoBackStep = false,
                            BoxCheckInRequired = true,
                            CreatedBy = "077471",
                            DateCreated = new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2521),
                            DateModified = new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2523),
                            DefaultNextStep = 4,
                            IsBoxEntryStep = false,
                            ModifiedBy = "077471",
                            PrefillBallotCount = false,
                            StepName = "Early Ballot Board Verification",
                            VaultHoldIsAvailable = true
                        },
                        new
                        {
                            StepId = 4,
                            AllowToGoBackStep = false,
                            BoxCheckInRequired = true,
                            CreatedBy = "077471",
                            DateCreated = new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2544),
                            DateModified = new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2545),
                            DefaultNextStep = 5,
                            IsBoxEntryStep = false,
                            ModifiedBy = "077471",
                            PrefillBallotCount = false,
                            StepName = "Early Ballot Board Ins Ctrl Brd",
                            VaultHoldIsAvailable = true
                        },
                        new
                        {
                            StepId = 5,
                            AllowToGoBackStep = false,
                            BoxCheckInRequired = true,
                            CreatedBy = "077471",
                            DateCreated = new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2563),
                            DateModified = new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2564),
                            DefaultNextStep = 6,
                            IsBoxEntryStep = false,
                            ModifiedBy = "077471",
                            PrefillBallotCount = false,
                            StepName = "Tabulation",
                            VaultHoldIsAvailable = true
                        },
                        new
                        {
                            StepId = 6,
                            AllowToGoBackStep = true,
                            BoxCheckInRequired = true,
                            CreatedBy = "077471",
                            DateCreated = new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2587),
                            DateModified = new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2589),
                            DefaultNextStep = 6,
                            IsBoxEntryStep = false,
                            ModifiedBy = "077471",
                            PrefillBallotCount = false,
                            StepName = "Completed to Vault",
                            VaultHoldIsAvailable = false
                        },
                        new
                        {
                            StepId = 7,
                            AllowToGoBackStep = false,
                            BoxCheckInRequired = true,
                            CreatedBy = "073098",
                            DateCreated = new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2606),
                            DateModified = new DateTime(2019, 12, 5, 15, 43, 17, 320, DateTimeKind.Local).AddTicks(2607),
                            IsBoxEntryStep = false,
                            ModifiedBy = "073098",
                            PrefillBallotCount = false,
                            StepName = "Vault Hold",
                            VaultHoldIsAvailable = false
                        });
                });

            modelBuilder.Entity("Ace.Web.Core.StepContact", b =>
                {
                    b.Property<int>("StepContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.Property<int>("StepId")
                        .HasColumnType("int");

                    b.HasKey("StepContactId");

                    b.HasIndex("ContactId");

                    b.HasIndex("StepId");

                    b.ToTable("StepContact","BallotTrack");

                    b.HasData(
                        new
                        {
                            StepContactId = 1,
                            ContactId = 1,
                            StepId = 1
                        },
                        new
                        {
                            StepContactId = 2,
                            ContactId = 1,
                            StepId = 2
                        },
                        new
                        {
                            StepContactId = 3,
                            ContactId = 3,
                            StepId = 2
                        },
                        new
                        {
                            StepContactId = 4,
                            ContactId = 4,
                            StepId = 3
                        },
                        new
                        {
                            StepContactId = 5,
                            ContactId = 5,
                            StepId = 3
                        },
                        new
                        {
                            StepContactId = 6,
                            ContactId = 4,
                            StepId = 4
                        },
                        new
                        {
                            StepContactId = 7,
                            ContactId = 5,
                            StepId = 4
                        },
                        new
                        {
                            StepContactId = 8,
                            ContactId = 6,
                            StepId = 5
                        },
                        new
                        {
                            StepContactId = 9,
                            ContactId = 7,
                            StepId = 5
                        },
                        new
                        {
                            StepContactId = 10,
                            ContactId = 1,
                            StepId = 6
                        },
                        new
                        {
                            StepContactId = 11,
                            ContactId = 3,
                            StepId = 6
                        },
                        new
                        {
                            StepContactId = 12,
                            ContactId = 1,
                            StepId = 7
                        },
                        new
                        {
                            StepContactId = 13,
                            ContactId = 3,
                            StepId = 7
                        });
                });

            modelBuilder.Entity("Ace.Web.Core.StepContact", b =>
                {
                    b.HasOne("Ace.Web.Core.Contact", "Contact")
                        .WithMany("StepsContact")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ace.Web.Core.Step", "Step")
                        .WithMany("ContactSteps")
                        .HasForeignKey("StepId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
