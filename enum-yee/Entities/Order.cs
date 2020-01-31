using enum_yee.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace enum_yee.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }
        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public void EsvaziarCarrinho()
        {
            Items.Clear();
        }
        public double Total()
        {
            double sum = 0.0;
            Items.ForEach(item =>
            {
                sum += item.SubTotal();
            });
            return sum;
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            builder.AppendLine("Order status: " + Status);
            builder.AppendLine("Client: " + Client);
            builder.AppendLine("Order items:");
            Items.ForEach(item =>
            {
                builder.AppendLine(item.ToString());
            });
            builder.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return builder.ToString();
        }
    }
}
