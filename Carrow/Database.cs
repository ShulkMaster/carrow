using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Carrow
{
    public class Database
    {

        private readonly List<string> _db = new List<string>
        {
            "Juan",
            "Miguel",
            "Pedro",
            "Ana",
            "Sofia",
            "Federico",
        };

        public List<string> ReadCustomers(int count)
        {
            if (count > _db.Count)
            {
                throw new DataException("cannot open DB connection");
            }

            return _db.Take(count).ToList();
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