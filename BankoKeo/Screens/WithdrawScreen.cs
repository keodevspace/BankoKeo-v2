using System;
using Bankokeo.Models;
using Bankokeo.Repositories;

namespace Bankokeo.Screens
{
    public static class WithdrawScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Saque");
            Console.WriteLine("-------------");
            Console.Write("Digite o id da conta: ");
            var accountId = Console.ReadLine();
            Console.Write("Digite o valor a ser sacado: ");
            var amount = Console.ReadLine();
            Withdraw(int.Parse(accountId), decimal.Parse(amount));
            Console.ReadKey();
            MenuScreen.Load();
        }

        public static void Withdraw(int accountId, decimal amount)
        {
            var repository = new Repository<Account>(Database.Connection);
            var account = repository.Get(accountId);
            if (account.Balance < amount)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }
            account.Balance -= amount;
            repository.Update(account);
            Console.WriteLine("Saque efetuado com sucesso!");
        }
    }
}