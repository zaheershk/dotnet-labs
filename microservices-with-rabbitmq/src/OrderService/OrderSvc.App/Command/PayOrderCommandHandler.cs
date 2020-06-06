using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OrderSvc.Data.Repository;
using OrderSvc.Domain;

namespace OrderSvc.App.Command
{
    public class PayOrderCommandHandler : IRequestHandler<PayOrderCommand, Order>
    {
        private readonly IRepository<Order> _repository;

        public PayOrderCommandHandler(IRepository<Order> repository)
        {
            _repository = repository;
        }

        public async Task<Order> Handle(PayOrderCommand request, CancellationToken cancellationToken)
        {
            return await _repository.UpdateAsync(request.Order);
        }
    }
}