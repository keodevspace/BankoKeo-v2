using static Database;
namespace Bankokeo.Screens
{
    public static class MenuScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("--------------Menu---------------");
            Console.WriteLine("|----                           |");
            Console.WriteLine("| 1 |  Saldo                    |");
            Console.WriteLine("| 2 |  Depósito                 |");
            Console.WriteLine("| 3 |  Transferência            |");
            Console.WriteLine("| 4 |  Saque                    |");
            Console.WriteLine("| 5 |  Sair do caixa eletrônico |");
            Console.WriteLine("|----                           |");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    BalanceScreen.Load();
                    break;
                case 2:
                    DepositScreen.Load();
                    break;
                case 3:
                    TransferScreen.Load();
                    break;
                case 4:
                    WithdrawScreen.Load();
                    break;
                default: Load(); break;
                
            }
        }
    }
}
            