using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new IndividualCustomer();
            Customer customer2 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
