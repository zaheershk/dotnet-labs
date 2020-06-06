using System;
using System.Collections.Generic;
using MediatR;
using OrderSvc.Domain;

namespace OrderSvc.App.Query
{
    public class GetOrderByCustomerGuidQuery : IRequest<List<Order>>
    {
        public Guid CustomerCuid { get; set; }
    }
}