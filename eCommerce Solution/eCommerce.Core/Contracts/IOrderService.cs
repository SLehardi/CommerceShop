using eCommerce.Core.Models;
using eCommerce.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Core.Contracts
{
    public interface IOrderService
    {
        void CreateOrder(Order baseOrder, List<BasketItemViewModel> basketItems);
        List<Order> GetOrderList();
        Order GetOrder(string id);
        void UpdateOrder(Order updateOrder);
    }
}
