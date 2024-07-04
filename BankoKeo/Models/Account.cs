using Dapper.Contrib.Extensions;

namespace Bankokeo.Models
{
    [Table("[Account]")]
    public class Account
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Balance { get; set; }
    }
}