using System;
using System.Collections.Generic;

namespace Carrow
{
    public class Repository
    {
        private readonly Database _database = new Database();

        public Result<List<string>> ReadCustomers()
        {
            try
            {
                return new Success<List<string>>(_database.ReadCustomers());
            }
            catch (Exception ex)
            {
                return new Failure<List<string>>(0, "cannot read data", ex);
            }
        }
    }
}