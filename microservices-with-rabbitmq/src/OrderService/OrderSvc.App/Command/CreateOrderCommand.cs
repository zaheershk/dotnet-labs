using MediatR;
using OrderSvc.Domain;

namespace OrderSvc.App.Command
{
    public class CreateOrderCommand : IRequest<Order>
    {
        public Order Order { get; set; }
    }
}
