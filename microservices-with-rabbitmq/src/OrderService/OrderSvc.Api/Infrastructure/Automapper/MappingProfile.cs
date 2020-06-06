using AutoMapper;
using OrderSvc.Domain;
using OrderSvc.Models;

namespace OrderSvc.Infrastructure.Automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<OrderModel, Order>()
                .ForMember(x => x.OrderState, opt => opt.MapFrom(src => 1));
        }
    }
}