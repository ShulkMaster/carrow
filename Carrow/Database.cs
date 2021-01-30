using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Carrow
{
    internal class Database
    {
        private static int _insertCount = 0;

        private readonly List<string> _db = new List<string>
        {
            "Juan",
            "Miguel",
            "Pedro",
            "Ana",
            "Sofia",
            "Federico",
        };

        public List<string> ReadCustomers()
        {
            _insertCount++;
            if (_insertCount % 5 == 0)
            {
                throw new DataException("cannot open DB connection");
            }

            return _db.ToList();
        }

        public void AddCustomer(string customer)
        {
            if (customer.Trim() == string.Empty)
            {
                throw new ArgumentException("nameless customer is invalid", customer);
            }

            _db.Add(customer);
        }
    }
}