using Dapper.Contrib.Extensions;

namespace Bankokeo.Models
{
    [Table("[UserAccountView]")]
    public class UserAccountView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int AccountId { get; set; }
        public decimal Balance { get; set; }
    }
}