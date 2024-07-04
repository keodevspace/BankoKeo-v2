using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace Bankokeo.Models
{
    [Table("[User]")]
    public class User
    {
        public User()
            => Roles = new List<Role>();

        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        [Write(false)]
        public List<Account> Accounts { get; set; }
    }
}