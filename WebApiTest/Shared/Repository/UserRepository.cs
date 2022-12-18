using Dapper;
using Microsoft.Extensions.Configuration;
using Src.Shared.Domain;
using Src.Shared.Repository.Interface;
using Src.Shared.Repository.Query;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Src.Shared.Repository
{
    public class UserRepository : IUserRepository
    {
        public IDbConnection _connection;
        public readonly IConfiguration _configuration;

        public UserRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection(configuration.GetSection("ConnectionString").Value);
            _connection.Open();
                    }
        public async Task<IList<User>> GetUserByIdAsync(int id)
        {
            var query = await _connection.QueryAsync<User>(UserQuery.GetUserByIdQuery, new
            {
                id
            });
            return query.ToList();
        }



    }
}
