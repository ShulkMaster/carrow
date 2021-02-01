using System;
using System.Collections.Generic;
using Carrow.Data;

namespace Carrow.Repositories
{
    ///  <include file='../Docs/Repositories.xml' path='docs/members[@name="Repository"]/Repository/*'/>
    public class Repository : IRepository
    {
        private readonly IDatabase _database;

        ///  <include file='../Docs/Repositories.xml' path='docs/members[@name="Repository"]/Contructor/*'/>
        public Repository(IDatabase database)
        {
            _database = database;
        }

        ///  <include file='../Docs/Repositories.xml' path='docs/members[@name="Repository"]/ReadCustomers/*'/>
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

        private void DoNothing()
        {
            Console.Write("this is private");
        }
    }
}