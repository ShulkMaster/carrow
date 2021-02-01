using System.Collections.Generic;

namespace Carrow.Data
{
    /// <include file='../Docs/Database.xml' path='docs/members[@name="IDatabase"]/IDatabase/*'/>
    public interface IDatabase
    {
        /// <include file='../Docs/Database.xml' path='docs/members[@name="Database"]/ReadCustomers/*'/>
        List<string> ReadCustomers(int count);

        /// <include file='../Docs/Database.xml' path='docs/members[@name="Database"]/AddCustomer/*'/>
        void AddCustomer(string customer);
    }
}