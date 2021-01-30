using System.Collections.Generic;

namespace Carrow
{
    public class Controller
    {
        private readonly Service _service = new Service();

        public Result<List<string>> LoadCustomers(bool transform, int count)
        {
            return _service.LoadCustomer(transform, count);
        }
    }
}