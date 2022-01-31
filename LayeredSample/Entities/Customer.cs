using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredSample.Entities
{
    internal class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NationalityId { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
