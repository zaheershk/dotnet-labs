using CustomerSvc.Domain.Entities;
using MediatR;

namespace CustomerSvc.App.Command
{
    public class UpdateCustomerCommand : IRequest<Customer>
    {
        public Customer Customer { get; set; }
    }
}
