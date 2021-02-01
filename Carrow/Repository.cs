using System;
using System.Collections.Generic;
using Carrow.Data;

namespace Carrow
{
    public class Repository
    {
        private readonly IDatabase _database;

        public Repository(IDatabase database)
        {
            _database = database;
        }

        public Result<List<string>> ReadCustomers(int count)
        {
            try
            {
                return new Success<List<string>>(_database.ReadCustomers(count));
            }
            catch (Exception ex)
            {
                return new Failure<List<string>>(0, "cannot read data", ex);
            }
        }
    }
}