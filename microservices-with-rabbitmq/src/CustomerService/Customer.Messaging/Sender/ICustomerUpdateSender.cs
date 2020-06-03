using CustomerSvc.Domain.Entities;

namespace CustomerSvc.Messaging.Sender
{
    public interface ICustomerUpdateSender
    {
        void SendCustomer(Customer customer);
    }
}
