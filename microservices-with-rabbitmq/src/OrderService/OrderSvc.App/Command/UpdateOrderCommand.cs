using System.Collections.Generic;
using MediatR;
using OrderSvc.Domain;

namespace OrderSvc.App.Command
{
    public class UpdateOrderCommand : IRequest
    {
        public List<Order> Orders { get; set; }
    }
}