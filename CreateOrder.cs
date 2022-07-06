namespace Exercicio_nelio
{
    public static class CreateOrder
    {
        public static Client RegisterNewClient()
        {
            string clientName = Messages.GetNome();
            string clientEmail = Messages.GetEmail();
            DateTime clientBirth = Messages.GetBirthDate();
            var cliente = new Client(clientName, clientEmail, clientBirth);
            return cliente;
        }
        public static Product CreateProduct()
        {
            Console.WriteLine("Digite o nome do produto:");
            string productName = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto:");
            double productPrice = double.Parse(Console.ReadLine());
            var produto = new Product(productName, productPrice);
            return produto;
        }
        public static OrderItem CreateOrderItem()
        {
            Product produto = CreateProduct();
            Console.WriteLine("Digite a quantidade do produto:");
            int productQuantity = int.Parse(Console.ReadLine());
            var orderItem = new OrderItem(produto, productQuantity);
            return orderItem;
        }
        public static Order CreateNewOrder()
        {
            var cliente = RegisterNewClient();
            var newOrder = new Order(cliente);
            bool encerraPedido = false;
            while (!encerraPedido)
            {
                AddItemToOrder(newOrder);
                Console.WriteLine(@"Gostaria de adicionar outro item?
1 - Sim
2 - Não
");
                int resposta = int.Parse(Console.ReadLine());
                encerraPedido = resposta == 2 ? true : false;
            }
            return newOrder;
        }
        public static void AddItemToOrder(Order order)
        {
            var pedido = CreateOrderItem();
            order.AddItem(pedido);
        }
    }
}
