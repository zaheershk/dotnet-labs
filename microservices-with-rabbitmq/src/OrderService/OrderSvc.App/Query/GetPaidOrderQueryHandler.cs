using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OrderSvc.Data.Repository;
using OrderSvc.Domain;

namespace OrderSvc.App.Query
{
    public class GetPaidOrderQueryHandler : IRequestHandler<GetPaidOrderQuery, List<Order>>
    {
        private readonly IRepository<Order> _repository;

        public GetPaidOrderQueryHandler(IRepository<Order> repository)
        {
            _repository = repository;
        }

        public async Task<List<Order>> Handle(GetPaidOrderQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAll().Where(x => x.OrderState == 2).ToListAsync(cancellationToken);
        }
    }
}