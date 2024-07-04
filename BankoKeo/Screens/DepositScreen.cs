using System;
using Bankokeo.Models;
using Bankokeo.Repositories;

namespace Bankokeo.Screens
{
    public static class DepositScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Depósito");
            Console.WriteLine("-------------");
            Console.Write("Digite o id da conta: ");
            var accountId = Console.ReadLine();
            Console.Write("Digite o valor a ser depositado: ");
            var amount = Console.ReadLine();
            Deposit(int.Parse(accountId), decimal.Parse(amount));
            Console.ReadKey();
            MenuScreen.Load();
        }

        public static void Deposit(int accountId, decimal amount)
        {
            var repository = new Repository<Account>(Database.Connection);
            var account = repository.Get(accountId);
            account.Balance += amount;
            repository.Update(account);
            Console.WriteLine("Depósito efetuado com sucesso!");
        }
    }
}