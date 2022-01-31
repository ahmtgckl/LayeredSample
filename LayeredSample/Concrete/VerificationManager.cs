using LayeredSample.Entities;
using LayeredSample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredSample.Concrete
{
    internal class VerificationManager : IVerificationService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            if (customer.NationalityId.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
