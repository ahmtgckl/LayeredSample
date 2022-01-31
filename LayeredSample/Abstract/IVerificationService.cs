using LayeredSample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredSample.Abstract
{
    internal interface IVerificationService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
