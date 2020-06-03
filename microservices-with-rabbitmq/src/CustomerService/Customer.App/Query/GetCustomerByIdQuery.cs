using CustomerSvc.Domain.Entities;
using MediatR;
using System;

namespace CustomerSvc.App.Query
{
    public class GetCustomerByIdQuery : IRequest<Customer>
    {
        public Guid Id { get; set; }
    }
}
