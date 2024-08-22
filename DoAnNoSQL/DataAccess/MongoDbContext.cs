using DoAnNoSQL.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNoSQL.DataAccess
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase database;
        public string DatabaseName { get; }

        public MongoDbContext(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            database = client.GetDatabase(databaseName);
            DatabaseName = databaseName;
        }

        public IMongoCollection<Customer> khachhang => database.GetCollection<Customer>("khachhang");
    }
}
