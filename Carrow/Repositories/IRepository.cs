using System.Collections.Generic;

namespace Carrow.Repositories
{
    public interface IRepository
    {
        ///  <include file='../Docs/Repositories.xml' path='docs/members[@name="Repository"]/ReadCustomers/*'/>
        Result<List<string>> ReadCustomers(int count);
    }
}