namespace Exercicio_nelio
{
    public class OrderItem
    {
        public Product ProductOrder { get; set; }
        public int Quantity { get; private set; }
        public double Price { get; private set; }

        public OrderItem(Product produto, int quantitade)
        {
            ProductOrder = produto;
            Quantity = quantitade;
            Price = produto.Price;
        }
        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
