using CustomerSvc.Data.Repository;
using CustomerSvc.Domain.Entities;
using CustomerSvc.Messaging.Sender;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerSvc.App.Command
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, Customer>
    {
        private readonly IRepository<Customer> _repository;
        private readonly ICustomerUpdateSender _customerUpdateSender;

        public UpdateCustomerCommandHandler(IRepository<Customer> repository, ICustomerUpdateSender customerUpdateSender)
        {
            _repository = repository;
            _customerUpdateSender = customerUpdateSender;
        }

        public async Task<Customer> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _repository.UpdateAsync(request.Customer);

            _customerUpdateSender.SendCustomer(customer);

            return customer;
        }
    }
}
