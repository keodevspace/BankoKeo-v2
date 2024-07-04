using Bankokeo.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace Bankokeo.Repositories
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(SqlConnection connection)
            : base(connection)
                => _connection = connection;
        {
        }

    public List<User> GetWithRoles()
    {
        var query = @"
                SELECT 
    *
FROM 
    [User]
RIGHT JOIN 
    [Account] 
ON 
    [User].[Id] = [Account].[UserId];";

        var users = new List<User>();

        var items = _connection.Query<User, Account, User>(
            query,
            (user, account) =>
            {
                var usr = users.FirstOrDefault(x => x.Id == user.Id);
                if (usr == null)
                {
                    usr = user;
                    if (account != null)
                        usr.Account.Add(account);

                    users.Add(usr);
                }
                else
                    usr.Account.Add(account);

                return user;
            }, splitOn: "Id");

        return users;
    }
}
