using AutoMapper;
using CustomerSvc.Api.Models;
using CustomerSvc.Domain.Entities;

namespace CustomerSvc.Api.Infrastructure.Automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCustomerModel, Customer>().ForMember(x => x.Id, opt => opt.Ignore());

            CreateMap<UpdateCustomerModel, Customer>();
        }
    }
}
