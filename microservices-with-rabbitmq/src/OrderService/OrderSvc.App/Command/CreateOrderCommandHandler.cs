using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OrderSvc.Data.Repository;
using OrderSvc.Domain;

namespace OrderSvc.App.Command
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Order>
    {
        private readonly IRepository<Order> _repository;

        public CreateOrderCommandHandler(IRepository<Order> repository)
        {
            _repository = repository;
        }

        public async Task<Order> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            return await _repository.AddAsync(request.Order);
        }
    }
}