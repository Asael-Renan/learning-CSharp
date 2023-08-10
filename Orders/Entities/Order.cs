using Oders.Entities.Enums;
using System.Text;

namespace Oders.Entities
{
    class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();


        public Order(OrderStatus status, Client client)
        {
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }
        public void RemoveItem(OrderItem orderItem)
        {
            OrderItems.Remove(orderItem);
        }

        public double Total()
        {
            double Total = 0;
            foreach (OrderItem orderItem in OrderItems)
            {
                Total += orderItem.SubTotal();
            }
            return Total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items: ");
            foreach (OrderItem orderItem in OrderItems)
            {
                sb.AppendLine(orderItem.ToString());
            }
            sb.AppendLine("Total price: " + Total());
            return sb.ToString();
        }
    }
}