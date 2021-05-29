using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Objects.OrderItems
{
    public interface IOrderItemType
    {
        public OrderItemTypes ItemType { get; set; }
    }
    public enum OrderItemTypes
    {
        Cash,
        Credit,
        CashOnDelivery,
        CreditOnDelivery,
        Transfer
    }
}
