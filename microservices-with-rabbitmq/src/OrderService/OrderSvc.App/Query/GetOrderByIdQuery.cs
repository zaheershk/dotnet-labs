using System;
using MediatR;
using OrderSvc.Domain;

namespace OrderSvc.App.Query
{
   public class GetOrderByIdQuery : IRequest<Order>
    {
        public Guid Id { get; set; }
    }
}
