using LayeredSample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredSample.Abstract
{
    internal interface ICustomerService
    {
        void Add(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);
    }
}
