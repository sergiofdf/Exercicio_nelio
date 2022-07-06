namespace Exercicio_nelio
{
    public static class PrintOrder
    {
        public static void PrintNewOrder(Order order)
        {
            Console.WriteLine($@"Order Summary
Order Moment: {order.Moment}
Order Status: {order.Status}
Cliente: { order.ClientOrder.Name } ({order.ClientOrder.BirthDate.ToShortDateString()}) - {order.ClientOrder.Email}
Order Client:
");
            foreach (var item in order.Items)
            {
                Console.WriteLine($"{item.ProductOrder.Name}, {item.ProductOrder.Price}, {item.SubTotal()}");
            }
            Console.WriteLine($"Total: {order.Total()}");
        }
    }
}
