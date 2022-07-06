namespace Exercicio_nelio
{
    public static class Messages
    {
        public static string GetNome()
        {
            Console.WriteLine("Digite o nome do cliente:");
            string clientName = Console.ReadLine();
            return clientName;
        }
        public static string GetEmail()
        {
            Console.WriteLine("Digite o email do cliente:");
            string clientEmail = Console.ReadLine();
            return clientEmail;
        }
        public static DateTime GetBirthDate()
        {
            Console.WriteLine("Digite a data de nascimento do cliente:");
            DateTime clientBirth = DateTime.Parse(Console.ReadLine());
            return clientBirth;
        }
    }
}
