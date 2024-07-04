using Bankokeo.Models;
using Bankokeo.Repositories;
using static Database;
namespace Bankokeo.Screens
{
    public static class LoginScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Login");
            Console.WriteLine("-----");
            Console.Write("Digite sua conta: ");
            var account = Console.ReadLine();
            Console.Write("Digite sua senha: ");
            var password = Console.ReadLine();
            Login(int.Parse(account), password);
            Console.ReadKey();
            MenuScreen.Load();
        }

        public static void Login(int account, string password)
        {
            var repository = new Repository<Account>(Database.Connection);
            var accountModel = repository.Get(account);
            if (accountModel == null)
            {
                Console.WriteLine("Conta não encontrada!");
                return;
            }
            if (accountModel.Password != password)
            {
                Console.WriteLine("Senha incorreta!");
                return;
            }
            Console.WriteLine("Login efetuado com sucesso!");
        }
    }
}
    
    
    
    
