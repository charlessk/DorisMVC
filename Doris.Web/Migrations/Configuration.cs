namespace Doris.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Doris.Domain;
    using System.Web.Security;
    using WebMatrix.WebData;

    internal sealed class Configuration : DbMigrationsConfiguration<Doris.Web.DataSources.DorisDataSource>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Doris.Web.DataSources.DorisDataSource context)
        {
            
            context.Tickets.AddOrUpdate(
            
                        new Ticket() { Name = "Just a name", Text = "nmghgfædå", Locked = true,   CreateDate = DateTime.Now,    TicketPriorityId = 1, TicketStatusId = 2},
                        new Ticket() { Name = "DFDGFJyrdf", Text = "nmghgfædå",  Locked = true,   CreateDate = DateTime.Now,    TicketPriorityId = 1, TicketStatusId = 2 },
                        new Ticket() { Name = "adsfsdxfdsf", Text = "nmghgfædå", Locked = true,   CreateDate = DateTime.Now,    TicketPriorityId = 2, TicketStatusId = 2 },
                        new Ticket() { Name = "kljhjhihgg", Text = "nmghgfædå",  Locked = true,   CreateDate = DateTime.Now,    TicketPriorityId = 3, TicketStatusId = 2 },
                        new Ticket() { Name = "bhjgfgf fd", Text = "nmghgfædå",  Locked = false,  CreateDate = DateTime.Now,    TicketPriorityId = 5, TicketStatusId = 2 }
                );
            
            context.Messages.AddOrUpdate(
               p=> p.Body,
                        new Message() { Body = "nmghgfædå", TicketId = 1},
                        new Message() { Body = "nmghgfædå", TicketId = 1},
                        new Message() { Body = "nmghgfædå", TicketId = 2},
                        new Message() { Body = "nmghgfædå", TicketId = 3},
                        new Message() { Body = "nmghgfædå", TicketId = 3}
                );

            context.TicketStatuses.AddOrUpdate(
                    p => p.StatusName,
                        new TicketStatus() { StatusName = "Awaiting" },
                        new TicketStatus() { StatusName = "Open" },
                        new TicketStatus() { StatusName = "Closed" }
                );
            
           
            context.TicketTicketPriorities.AddOrUpdate(
                p=>p.Priority,
                    new TicketPriority(){Priority = "1"},
                    new TicketPriority(){Priority = "2"},
                    new TicketPriority(){Priority = "3"},
                    new TicketPriority(){Priority = "4"},
                    new TicketPriority(){Priority = "5"}
                );

            SeedMembership();
            SeedCustomer(context);
        }

        private void SeedCustomer(Doris.Web.DataSources.DorisDataSource context)
        {
            context.CustomerTypes.AddOrUpdate(
               p => p.Name,
               new CustomerType() { Name = "User" },
               new CustomerType() { Name = "Company" },
               new CustomerType() { Name = "Organization" }
               );

        }

        private void SeedMembership()
        {
           
            if (!WebSecurity.Initialized)
            {
                WebSecurity.InitializeDatabaseConnection("DefaultConnection",
                    "User", "UserId", "UserName", autoCreateTables: true);
            }

            var roles = (SimpleRoleProvider)Roles.Provider;
            var membership = (SimpleMembershipProvider)Membership.Provider;

            if (!roles.RoleExists("Admin"))
            {
                roles.CreateRole("Admin");
            }
            if (membership.GetUser("charles_sk", false) == null)
            {
                membership.CreateUserAndAccount("charles_sk", "Amiga4000");
            }
            if (!roles.GetRolesForUser("charles_sk").Contains("Admin"))
            {
                roles.AddUsersToRoles(new[] { "charles_sk" }, new[] { "admin" });
            }
             
        }
    }
}
