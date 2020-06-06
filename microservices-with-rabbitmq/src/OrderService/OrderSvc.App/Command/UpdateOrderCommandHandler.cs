using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OrderSvc.Data.Repository;
using OrderSvc.Domain;

namespace OrderSvc.App.Command
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand>
    {
        private readonly IRepository<Order> _repository;

        public UpdateOrderCommandHandler(IRepository<Order> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            await _repository.UpdateRangeAsync(request.Orders);

            return Unit.Value;
        }
    }
}