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
        private int m_idCounter;

        public CustomerManager()
        {
            customers = new ArrayList();
            m_idCounter = 100;
        }

        public int Count
        {
            get { return customers.Count; }
        }

        public int GetNewID
        {
            get { return m_idCounter++; }
        }

        public bool AddCustomer(Customer customerIn)
        {
            customerIn.ID = GetNewID.ToString();
            customers.Add(customerIn);
                return true;
        }

        private bool IsValidIndex(int index)
        {
            if (index >= 0 && index < Count)
                return true;
            else
                return false;
        }

        public bool ChangeCustomer(Contact contactIn, int index)
        {
            if(IsValidIndex(index))
            {

            Customer customer = (Customer)customers[index];
            customer.ContactData = contactIn;        
            customers.RemoveAt(index);
            customers.Insert(index, customer);
            return true;
            }
            else
                return false;
        }

        public bool RemoveCustomer(int index)
        {
            if (IsValidIndex(index))
            {
                customers.RemoveAt(index);
                return true;
            }
            else
                return false;
        }

        public Customer GetCustomer(int index)
        {
            return (Customer)customers[index];
        }

        public void TestValues()
        {
            Address a1 = new Address("Stenbergsgränd 19", "37133", "karlskrona", Countries.Sverige);
            Email email = new Email("nrkkalyan@gmail.com");
            Phone phone = new Phone("123455", "234556");

            Contact contact = new Contact("Kalyan", "Nimmagadda", a1, email, phone);

            Customer customer = new Customer(contact);

            customers.Add(customer);

        }
    }
}
