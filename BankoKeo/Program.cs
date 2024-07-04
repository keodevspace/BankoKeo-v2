using Bankokeo.Screens;
using Microsoft.Data.SqlClient;

namespace Bankokeo
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Bankokeo;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True;";

        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            Load();

            Console.ReadKey();
            Database.Connection.Close();
        }

        private static void Load()
        {
            Console.Write(".");
            Thread.Sleep(2000);
            Console.Write(".");
            Thread.Sleep(2000);
            Console.Write(".");
            Thread.Sleep(2000);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("$$$  BOAS-VINDAS AO Bankokeo  $$$");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("");

            var option = short.Parse(Console.ReadLine()!);

            LoginScreen.Load();

        }
    }
}
