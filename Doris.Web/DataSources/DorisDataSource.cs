using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Doris.Domain;
using System.Data;

namespace Doris.Web.DataSources
{
    public class DorisDataSource : DbContext, IDorisDataSource
    {
        public DorisDataSource()
            : base("DefaultConnection")
        {
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketPriority> TicketTicketPriorities { get; set; }
        public DbSet<TicketStatus> TicketStatuses { get; set; }
        public DbSet<Zip> PostCodes { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<EmailServer> EmailServers { get; set; }

        public DbSet<Message> Messages { get; set; }
        public DbSet<MessageType> MessageTypes { get; set; }
        public DbSet<MessageAttachment> MessageAttachments { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }

        public DbSet<Responses> Responseses { get; set; }

        IQueryable<T> IDorisDataSource.Query<T>()
        {
            return Set<T>();
        }

        void IDorisDataSource.Add<T>(T entity)
        {
            Set<T>().Add(entity);
        }

        void IDorisDataSource.Update<T>(T entity)
        {
            Entry(entity).State = EntityState.Modified;
        }

        void IDorisDataSource.Remove<T>(T entity)
        {
            Set<T>().Remove(entity);
        }

        IQueryable<Ticket> IDorisDataSource.Tickets
        {
            get { return Tickets; }
        }

        IQueryable<TicketStatus> IDorisDataSource.TicketStatuses
        {
            get { return TicketStatuses; }
        }

        IQueryable<TicketPriority> IDorisDataSource.TicketTicketPriorities
        {
            get { return TicketTicketPriorities; }
        }

        IQueryable<Zip> IDorisDataSource.PostCodes
        {
            get { return PostCodes; }
        }

        IQueryable<Email> IDorisDataSource.Emails
        {
            get { return Emails; }
        }
        
        IQueryable<EmailServer> IDorisDataSource.EmailServers
        {
            get { return EmailServers; }
        }

        IQueryable<Message> IDorisDataSource.Messages
        {
            get { return Messages; }
        }

        IQueryable<MessageType> IDorisDataSource.MessageTypes
        {
            get { return MessageTypes; }
        }

        IQueryable<MessageAttachment> IDorisDataSource.MessageAttachments
        {
            get { return MessageAttachments; }
        }

        IQueryable<Customer> IDorisDataSource.Customers
        {
            get { return Customers; }
        }

        IQueryable<CustomerType> IDorisDataSource.CustomerTypes
        {
            get { return CustomerTypes; }
        }

        IQueryable<Responses> IDorisDataSource.Responseses
        {
            get { return Responseses; }
        }

        void IDorisDataSource.SaveChanges()
        {
            SaveChanges();
        }
    }
}