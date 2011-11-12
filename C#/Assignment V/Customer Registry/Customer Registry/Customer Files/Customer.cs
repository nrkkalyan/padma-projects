using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Customer_Registry.Customer_Files
{
    public class Customer
    {
        private Contact m_contact;
        private string m_id;

        public Customer(Contact conact, string id)
        {
            m_contact = conact;
            m_id = id;
        }

        public Customer(Customer customerIn)
            : this(customerIn.ContactData, customerIn.ID)
        { }

        public Customer(): this(new Contact())
        { }

        public Customer(Contact contactIn)
            : this(contactIn, string.Empty)
        { }

        public Contact ContactData
        {
            get { return m_contact;}
            set { m_contact = value; }
        }

        public string ID
        {
            get { return m_id; }
            set { m_id = value; }
        }

        public override string ToString()
        {
            return m_id+" "+m_contact.ToString();
        }
    }
}
