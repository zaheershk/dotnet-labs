using CustomerSvc.Data.Repository;
using CustomerSvc.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerSvc.App.Command
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Customer>
    {
        private readonly IRepository<Customer> _repository;

        public CreateCustomerCommandHandler(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public async Task<Customer> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            return await _repository.AddAsync(request.Customer);
        }
    }
}
