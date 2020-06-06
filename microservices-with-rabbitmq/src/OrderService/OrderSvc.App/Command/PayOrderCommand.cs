using MediatR;
using OrderSvc.Domain;

namespace OrderSvc.App.Command
{
   public class PayOrderCommand : IRequest<Order>
    {
        public Order Order { get; set; }
    }
}
