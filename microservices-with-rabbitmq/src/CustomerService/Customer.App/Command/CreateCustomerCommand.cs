using CustomerSvc.Domain.Entities;
using MediatR;

namespace CustomerSvc.App.Command
{
    public class CreateCustomerCommand : IRequest<Customer>
    {
        public Customer Customer { get; set; }
    }
}
