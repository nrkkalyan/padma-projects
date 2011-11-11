using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Customer_Registry.Customer_Files
{
    public class CustomerManager
    {
        private ArrayList customers;

        public CustomerManager()
        {
            customers = new ArrayList();
        }

        public int Count
        {
            get { return customers.Count; }
        }

        public int GetNewID
        {
            get { return 100 + Count; }
        }

        public bool AddCustomer(Customer customerIn)
        {
            customers.Add(customerIn);
                return true;
        }

        public bool ChangeCustomer(Contact contactIn, int index)
        {
            customers.Insert(index, contactIn);
            return true;
        }

        public bool RemoveCustomer(int index)
        {
            customers.RemoveAt(index);
            return true;
        }

        public Customer GetCustomer(int index)
        {
            return (Customer)customers[index];
        }

        public void TestValues()
        {
            Address a1 = new Address("Stenbergsgränd 19", "37133", "karlskrona", Countries.Sverige);
            Email email = new Email("nrkkalyan@gmail.com");
            Phone phone = new Phone("123455", "234556", "134356");

            Contact contact = new Contact("Kalyan", "Nimmagadda", a1, email, phone);

            Customer customer = new Customer(contact);

            customers.Add(customer);

        }
    }
}
