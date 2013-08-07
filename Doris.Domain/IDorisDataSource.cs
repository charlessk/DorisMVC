using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doris.Domain
{
    public interface IDorisDataSource : IDisposable
    {
     
        IQueryable<T> Query<T>() where T : class;
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Remove<T>(T entity) where T : class;

        IQueryable<Ticket> Tickets { get; }
        IQueryable<TicketPriority> TicketTicketPriorities { get; }
        IQueryable<Zip> PostCodes { get; }
        IQueryable<Email> Emails { get; }
        IQueryable<EmailServer> EmailServers { get; }
        IQueryable<Message> Messages { get; }
        IQueryable<MessageType> MessageTypes { get; }
        IQueryable<MessageAttachment> MessageAttachments { get; }
        IQueryable<Customer> Customers { get; }
        IQueryable<CustomerType> CustomerTypes { get; }
        IQueryable<TicketStatus> TicketStatuses { get; }
        IQueryable<Responses> Responseses { get; }
        void SaveChanges();
    }
}
