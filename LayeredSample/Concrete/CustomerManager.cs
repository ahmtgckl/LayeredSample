using LayeredSample.Abstract;
using LayeredSample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredSample.Concrete
{
    internal class CustomerManager : ICustomerService
    {
        public CustomerManager()
        {

        }
        private IVerificationService verificationService;

        public CustomerManager(IVerificationService verificationService)
        {
            this.verificationService = verificationService;
        }

        public void Add(Customer customer)
        {
            if (verificationService.CheckIfRealPerson(customer))
            {
                Console.WriteLine(customer.FirstName + " " + customer.LastName + " adlı oyuncu eklendi.");
            }
            else
            {
                Console.WriteLine(" Bilgilerinizi tekrar kontrol ediniz.");
            }

        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " adlı oyuncu silindi.");

        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " adlı oyuncunun bilgileri güncellendi.");

        }
    }
}
