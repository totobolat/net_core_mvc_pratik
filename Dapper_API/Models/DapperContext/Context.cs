using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Npgsql;

namespace Dapper_API.Models.DapperContext
{
    public class Context
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public Context(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }
        public IDbConnection CreateConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }
        


    }
}
