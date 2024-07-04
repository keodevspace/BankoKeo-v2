using System;
using Bankokeo.Models;
using Bankokeo.Repositories;

namespace Bankokeo.Screens
{
    public static class BalanceScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Saldo");
            Console.WriteLine("-------------");
            Console.Write("Digite o id da conta: ");
            var accountId = Console.ReadLine();
            Console.WriteLine("Saldo atual: " + GetBalance(int.Parse(accountId)));
            Console.ReadKey();
            MenuScreen.Load();
        }

        public static decimal GetBalance(int accountId)
        {
            var repository = new Repository<Account>(Database.Connection);
            var account = repository.Get(accountId);
            return account.Balance;
        }
    }
}