namespace Exercicio_nelio
{
    public class Order
    {
        public DateTime Moment { get; private set; }
        public OrderStatus Status { get; private set; }
        public Client ClientOrder { get; private set; }
        public List<OrderItem> Items { get; private set; } = new();
        public Order(Client client, OrderStatus status = OrderStatus.PendingPayment)
        {
            Moment = DateTime.Now;
            ClientOrder = client;
            Status = status;
        }
        public void AddItem(OrderItem itemToAdd)
        {
            Items.Add(itemToAdd);
        }
        public void RemoveItem(OrderItem itemToRemove)
        {
            Items.Remove(itemToRemove);
        }
        public double Total()
        {
            double total = 0;
            foreach (var item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        }
    }
}
