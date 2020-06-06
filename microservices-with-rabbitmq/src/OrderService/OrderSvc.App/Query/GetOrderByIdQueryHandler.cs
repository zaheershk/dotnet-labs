using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OrderSvc.Data.Repository;
using OrderSvc.Domain;

namespace OrderSvc.App.Query
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, Order>
    {
        private readonly IRepository<Order> _repository;

        public GetOrderByIdQueryHandler(IRepository<Order> repository)
        {
            _repository = repository;
        }

        public async Task<Order> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAll().FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        }
    }
}