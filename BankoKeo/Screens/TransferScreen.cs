using Bankokeo.Models;
using Bankokeo.Repositories;
using static Database;
namespace Bankokeo.Screens
{
    public static class TransferScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Transferência");
            Console.WriteLine("-------------");
            Console.Write("Digite o id da conta de origem: ");
            var accountIdOrigin = Console.ReadLine();
            Console.Write("Digite o id da conta de destino: ");
            var accountIdDestination = Console.ReadLine();
            Console.Write("Digite o valor a ser transferido: ");
            var amount = Console.ReadLine();
            Transfer(int.Parse(accountIdOrigin), int.Parse(accountIdDestination), decimal.Parse(amount));
            Console.ReadKey();
            MenuScreen.Load();
        }

        public static void Transfer(int accountIdOrigin, int accountIdDestination, decimal amount)
        {
            var repository = new Repository<Account>(Database.Connection);
            var accountOrigin = repository.Get(accountIdOrigin);
            var accountDestination = repository.Get(accountIdDestination);
            accountOrigin.Balance -= amount;
            accountDestination.Balance += amount;
            repository.Update(accountOrigin);
            repository.Update(accountDestination);
            Console.WriteLine("Transferência efetuada com sucesso!");
        }
    }
}