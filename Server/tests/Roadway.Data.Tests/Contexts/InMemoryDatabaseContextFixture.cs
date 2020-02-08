using System;
using Microsoft.Data.Sqlite;

namespace Roadway.Data.Tests.Contexts
{
    public class InMemoryDatabaseContextFixture : IDisposable
    {
        protected readonly TestContext TestContext;
        private readonly SqliteConnection _connection;

        protected InMemoryDatabaseContextFixture()
        {
            _connection = new SqliteConnection("DataSource=:memory:");
            _connection.Open();
            TestContext = InMemoryDatabaseContextFactory.Create(_connection);
        }

        public void Dispose()
        {
            TestContext.Database.EnsureDeleted();
            _connection.Close();
        }
    }
}