using System.Collections.Generic;
using System.Linq;

namespace Carrow
{
    public class Service
    {
        private readonly Repository _repository = new Repository();

        public Result<List<string>> LoadCustomer()
        {
            var result = _repository.ReadCustomers();
            if (result is Success<List<string>> success)
            {
                return new Success<List<string>>(success.Value.Select(s => s.ToUpper()).ToList());
            }
            return result;
        }
    }
}