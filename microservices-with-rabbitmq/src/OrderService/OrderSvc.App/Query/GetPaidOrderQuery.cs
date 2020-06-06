using System.Collections.Generic;
using MediatR;
using OrderSvc.Domain;

namespace OrderSvc.App.Query
{
    public class GetPaidOrderQuery : IRequest<List<Order>>
    {
    }
}