using OrderSvc.App.Models;

namespace OrderSvc.App.Services
{
    public interface ICustomerNameUpdateService
    {
        void UpdateCustomerNameInOrders(UpdateCustomerFullNameModel updateCustomerFullNameModel);
    }
}